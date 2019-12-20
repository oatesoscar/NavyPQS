using System;
using System.Windows.Forms;

namespace NavyPQS
{
    public partial class AdminPanel : Form
    {
        FileIO fileIO = new FileIO();
        TextReadWrite textReadWrite = new TextReadWrite();
        JsonReadWrite jsonReadWrite = new JsonReadWrite();

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void bOpenTxtFile_Click(object sender, EventArgs e)
        {
            fileIO.GetTextFile();
            tTextFilePath.Text = fileIO.TxtFilePath;
        }

        private void bSelectTxtFilePath_Click(object sender, EventArgs e)
        {
            fileIO.SetTextFilePath();
            tTextFilePath.Text = fileIO.TxtFilePath;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            fileIO.JsonFilePath = string.Empty;
            fileIO.TxtFilePath = string.Empty;
            MessageBox.Show("Operation cancelled","User Cancelled",MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        private void bComplete_Click(object sender, EventArgs e)
        {
            textReadWrite.CreateQuestionObjects(textReadWrite.readTextFile(fileIO.TxtFilePath));
            jsonReadWrite.writeQuestionToJsonFile(textReadWrite.questionObjectList, fileIO.JsonFilePath);
            MessageBox.Show("Operation Complete");
            this.Hide();
            Questions questions = new Questions();
            questions.Show();
        }
    }
}
