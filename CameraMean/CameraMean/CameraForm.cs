using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarrenLee.Media;

namespace CameraMean
{
    public partial class CameraForm : Form
    {
        private Camera camera = new Camera();

        private Graphics graphics;

        private int Red { get; set; }
        private int Green { get; set; }
        private int Blue { get; set; }

        public CameraForm()
        {
            InitializeComponent();
        }

        private void CameraForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            KeyPreview = true;

            camera.OnFrameArrived += CameraForm_OnFrameArrived;
            graphics = redBox.CreateGraphics();

            int i = 0;
            List<string> resolutions = camera.GetSupportedResolutions();

            foreach (var resolution in resolutions)
            {
                if (resolution.Contains("640") && resolution.Contains("360"))
                    break;

                i++;
            }

            camera.Start(i);
            BlockInput(true);
        }

        [DllImportAttribute("user32.dll", EntryPoint = "BlockInput")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool BlockInput([MarshalAsAttribute(UnmanagedType.Bool)] bool fBlockIt);

        private Color CountMean(Image image)
        {
            var bitmap = new Bitmap(image, 320, 180);

            long red, green, blue;
            red = green = blue = 0;

            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    Color pixel = bitmap.GetPixel(j, i);
                    red += pixel.R;
                    green += pixel.G;
                    blue += pixel.B;
                }
            }

            red /= (bitmap.Width * bitmap.Height);
            green /= (bitmap.Width * bitmap.Height);
            blue /= (bitmap.Width * bitmap.Height);

            return Color.FromArgb((int)red, (int)green, (int)blue);
        }

        private void CameraForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4 && e.Shift)
            {
                Environment.Exit(0);
            }
        }

        private void CameraForm_OnFrameArrived(object sender, FrameArrivedEventArgs e)
        {
            Image image = e.GetFrame();

            Color colorMean = CountMean(image);
            colorMeanBox.BackColor = colorMean;

            graphics.Clear(BackColor);
            Font font = new Font(Font.FontFamily, 16);

            graphics.DrawString(colorMean.R.ToString(), font, Brushes.Red, new PointF(20, 0));
            graphics.DrawString(colorMean.G.ToString(), font, Brushes.Green, new PointF(20, 63));
            graphics.DrawString(colorMean.B.ToString(), font, Brushes.Blue, new PointF(20, 120));

            frameBox.Image = image;
        }

        private void CameraForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            camera.Stop();
            Environment.Exit(0);
        }

        private void CameraForm_FormClosed(object sender, FormClosedEventArgs e)
        { }
    }
}
