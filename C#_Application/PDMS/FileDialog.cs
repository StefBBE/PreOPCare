using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PDMS
{
    class FileDialog
    {
        public string filepath;
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse ecg Files",

                CheckFileExists = true,
                CheckPathExists = true,

                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filepath = Path.GetDirectoryName(openFileDialog1.FileName);
                System.Windows.Forms.MessageBox.Show(filepath);
            }
        }
    }
}
