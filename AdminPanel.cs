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
            tTextFilePath.Text = fileIO.TxtPath;
        }
        private void bSelectTxtFilePath_Click(object sender, EventArgs e)
        {
            fileIO.SetTextFilePath();
            tTextFilePath.Text = fileIO.TxtPath;
        }
        private void bCancel_Click(object sender, EventArgs e)
        {
            fileIO.JsonQuestions = string.Empty;
            fileIO.TxtPath = string.Empty;
            MessageBox.Show("Operation cancelled","User Cancelled",MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
        private void bComplete_Click(object sender, EventArgs e)
        {
            textReadWrite.CreateQuestionObjects(textReadWrite.ReadTextFile(fileIO.TxtPath));
            jsonReadWrite.writeQuestions(textReadWrite.questionObjectList, fileIO.JsonQuestions);
            MessageBox.Show("Operation Complete");
            Application.Exit();
        }
    }
}
