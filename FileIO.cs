using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NavyPQS
{
    class FileIO
    {
        public string TxtFilePath { get; set; }
        public string JsonFilePath { get; set; }

        public void GetTextFile()
        {
            // Bring up a dialog to chose a folder path in which to open a text file.
            OpenFileDialog openFile = new OpenFileDialog
            {
                Title = "Open Text File",
                Filter = "Text files(*.txt) | *.txt"
            };

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TxtFilePath = openFile.FileName;
            }
        }

        public void SetTextFilePath()
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TxtFilePath = folderBrowser.SelectedPath;
            }
        }

        public void GetJsonFile()
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Title = "Open Json File",
                Filter = "Json files(*.json) | *.json"
            };

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                JsonFilePath = openFile.FileName;
            }
        }

        public void SetJsonFilePath()
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                JsonFilePath = folderBrowser.SelectedPath;
            }
        }
    }
}
