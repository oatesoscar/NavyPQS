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
    public partial class Questions : Form
    {
        private User CurrentUser = new User();
        private JsonReadWrite JsonReadWrite = new JsonReadWrite();
        private List<QuestionSkeleton> questions = new List<QuestionSkeleton>();
        private Random random = new Random();
        private QuestionSkeleton question = new QuestionSkeleton();

        public Questions(string str)
        {
            InitializeComponent();
            GetQuestions();
            SetQuestion();
            CurrentUser = GetUser(str);
            tUsername.Text = CurrentUser.userName;
            tScore.Text = CurrentUser.score.ToString();
            tScoreMultiplyer.Text = CurrentUser.currentScoreMultiplyer.ToString();
        }

        private void AppExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetHighlightIcon(object sender, EventArgs e)
        {
            bExit.BackgroundImage = Properties.Resources.closeHighlight;
        }

        private void SetNormalIcon(object sender, EventArgs e)
        {
            bExit.BackgroundImage = Properties.Resources.icons8_close_window_100; 
        }

        private void SetMHicon(object sender, EventArgs e)
        {
            bMinimize.BackgroundImage = Properties.Resources.minimizeHighlight;
        }

        private void SetMNicon(object sender, EventArgs e)
        {
            bMinimize.BackgroundImage = Properties.Resources.minimizeNormal;
        }

        private void AppMinimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private User GetUser(string username)
        {
            JsonReadWrite jsonReadWrite = new JsonReadWrite();
            var UserList = jsonReadWrite.ReadUsers();
            var user = UserList.Find(r => r.userName == username);
            return user;
        }

        private void GetQuestions()
        {
            questions = JsonReadWrite.readQuestions();
        }

        private void SetQuestion()
        {
            var questionNumber = random.Next(0, questions.Count());
            var answerNumber = random.Next(1, 3);
            question = questions[questionNumber];
            tQuestion.Text = question.question;
            tAnswerA.Text = question.answer1;
            tAnswerB.Text = question.answer2;
            tAnswerC.Text = question.answer3;
        }

        

    }
}
