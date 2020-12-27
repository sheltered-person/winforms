using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndexFiles
{
    public partial class Form1 : Form
    {
        private OpenFileDialog fileDialog;

        private string fileName;

        public Form1()
        {
            InitializeComponent();

            fileDialog = new OpenFileDialog();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = fileDialog.FileName;
                fileTextBox.Text = fileDialog.SafeFileName;
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            try
            {
                Indexer indexer = new Indexer(fileName);
                indexer.ProcessFile();

                readTimeLabel.Text = $"{indexer.ReadTime} ms";
                countTimeLabel.Text = $"{indexer.CountTime} ms";

                readVelLabel.Text = string.Format("{0:f2} part / ms", indexer.ReadVelocity);
                countVelLabel.Text = string.Format("{0:f2} part / ms", indexer.CountVelocity);

                resultTextBox.Text = indexer.Report;

                totalTimeLabel.Text = $"{indexer.TotalTime} ms";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
