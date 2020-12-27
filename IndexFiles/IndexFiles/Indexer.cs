using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IndexFiles
{
    public class Indexer
    {
        private string fileName;

        private FileInfo fileInfo;

        public string Report { get; private set; }

        public long ReadTime { get; private set; }

        public long CountTime { get; private set; }

        public long TotalTime { get; private set; }

        public double ReadVelocity { get; private set; }

        public double CountVelocity { get; private set; }

        public Indexer(string fileName)
        {
            if (!File.Exists(fileName))
            {
                throw new ArgumentException("No such file!");
            }

            this.fileName = fileName;
            fileInfo = new FileInfo(fileName);
        }

        public void ProcessFile()
        {
            long partSize = (long)Math.Ceiling(fileInfo.Length / 128.0);
            long partsCount = fileInfo.Length / partSize;

            if (fileInfo.Length % partSize != 0)
            {
                partsCount++;
            }

            if (partSize > int.MaxValue)
            {
                Console.WriteLine("File is too big for indexing.");
                return;
            }

            byte[][] hashes = new byte[(int)partsCount][];
            Task[] tasks = new Task[(int)partsCount];
            long[] countTimes = new long[(int)partsCount];

            ReadTime = 0;

            Stopwatch totalTime = new Stopwatch();
            totalTime.Start();

            using (FileStream fileStream = File.Open(fileName, FileMode.Open))
            {
                for (int i = 0; i < partsCount; i++)
                {
                    if (i == partsCount - 1)
                    {
                        partSize = (int)fileInfo.Length % (partSize - 1);
                    }

                    byte[] part = new byte[partSize];

                    Stopwatch reading = new Stopwatch();
                    reading.Start();

                    fileStream.Read(part, 0, (int)partSize);

                    reading.Stop();
                    ReadTime += reading.ElapsedMilliseconds;

                    int k = i;

                    tasks[i] = new Task(() =>
                    {
                        using (MD5 md5 = MD5.Create())
                        {
                            Stopwatch counting = new Stopwatch();
                            counting.Start();

                            byte[] partHash = md5.ComputeHash(part);
                            hashes[k] = partHash;

                            counting.Stop();
                            countTimes[k] = counting.ElapsedMilliseconds;
                        }
                    });

                    tasks[i].Start();
                }
            }

            Task.WaitAll(tasks);
            totalTime.Stop();

            CountTime = 0;
            StringBuilder report = new StringBuilder();

            for (int i = 0; i < partsCount; i++)
            {
                CountTime += countTimes[i];
                var str = new StringBuilder();

                for (int j = 0; j < hashes[i].Length; j++)
                {
                    str.Append(hashes[i][j].ToString("x2"));
                }

                report.Append(str + "\n");
            }

            ReadVelocity = (double) partsCount / ReadTime;
            CountVelocity = (double) partsCount / CountTime;

            TotalTime = totalTime.ElapsedMilliseconds;
            Report = report.ToString();
        }
    }
}
