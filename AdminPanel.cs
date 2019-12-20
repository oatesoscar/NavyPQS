using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NavyPQS
{
    public partial class AdminPanel : Form
    {
        FileIO fileIO = new FileIO();
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void bOpenTxtFile_Click(object sender, EventArgs e)
        {
            fileIO.GetTextFile();
            tTextFilePath.Text = fileIO.TxtFilePath;
        }

        private void bOpenJsonFile_Click(object sender, EventArgs e)
        {
            fileIO.GetJsonFile();
            tJsonFilePath.Text = fileIO.JsonFilePath;
        }

        private void bSelectTxtFilePath_Click(object sender, EventArgs e)
        {
            fileIO.SetTextFilePath();
            tTextFilePath.Text = fileIO.TxtFilePath;
        }

        private void bSelectJsonFilePath_Click(object sender, EventArgs e)
        {
            fileIO.SetJsonFilePath();
            tJsonFilePath.Text = fileIO.JsonFilePath;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            fileIO.JsonFilePath = string.Empty;
            fileIO.TxtFilePath = string.Empty;
            MessageBox.Show("Operation cancelled");            
        }

        private void bComplete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
