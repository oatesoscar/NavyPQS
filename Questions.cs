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
        private List<QuestionSkeleton> allQuestions = new List<QuestionSkeleton>();
        private Random random = new Random();
        private QuestionSkeleton question = new QuestionSkeleton();
        private List<int> UsedQuestionNumber = new List<int>();
        private int questionNumber;
        private int previousQuestionNumber;
        private string correctAnswer;
        private int scoreMultipliyer = 1;
        private bool failedOnce;
        private bool noMoreQuestions;
        private bool scoreStored;

        public Questions(string str)
        {
            InitializeComponent();
            GetQuestions();
            SetQuestion();
            CurrentUser = GetUser(str);
            tUsername.Text = CurrentUser.userName;
            tScore.Text = CurrentUser.score.ToString();
            tLastScore.Text = CurrentUser.lastScore.ToString();
            tScoreMultiplyer.Text = CurrentUser.currentScoreMultiplyer.ToString();
            questionNumber = random.Next(0, allQuestions.Count());
            noMoreQuestions = false;
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

        private void bNext_Click(object sender, EventArgs e)
        {
            if (noMoreQuestions == false)
            {
                SetNextQuestion();
            }
            else
            {
                if (scoreStored == true)
                {
                    MessageBox.Show("No More questions");
                }
                else
                {
                    MessageBox.Show("No More questions");
                    SaveUserScore();
                }              
            }
        }

        private void bPrevious_Click(object sender, EventArgs e)
        {
            if (noMoreQuestions == false)
            {
                SetPreviousQuestion();
            }
            else
            {
                if (scoreStored == true)
                {
                    MessageBox.Show("No More questions");
                }
                else
                {
                    MessageBox.Show("No More questions");
                    SaveUserScore();
                }
            }    
        }

        private void bA_Click(object sender, EventArgs e)
        {
            CheckAnswer("1");
        }

        private void bB_Click(object sender, EventArgs e)
        {
            CheckAnswer("2");
        }

        private void bC_Click(object sender, EventArgs e)
        {
            CheckAnswer("3");
        }

        private void CheckAnswer(string userAnswer)
        {
            if (noMoreQuestions == false)
            {
                if (userAnswer == correctAnswer)
                {
                    MessageBox.Show("You passed");
                    SetNextQuestion();
                    SetScore(100 * scoreMultipliyer);
                    scoreMultipliyer++;
                }
                else
                {
                    MessageBox.Show("You Failed");
                    if (failedOnce == true)
                    {
                        scoreMultipliyer = 1;
                        failedOnce = false;
                    }
                    else
                    {
                        scoreMultipliyer++;
                        failedOnce = true;
                    }
                    SetScore(-100 * scoreMultipliyer);
                    StopGame();
                }
            }
            else
            {
                if (scoreStored == true)
                {
                    MessageBox.Show("No More questions");
                }
                else
                {
                    MessageBox.Show("No More questions");
                    SaveUserScore();
                }
            }

        }

        private User GetUser(string username)
        {
            JsonReadWrite jsonReadWrite = new JsonReadWrite();
            var UserList = jsonReadWrite.ReadUsers();
            var user = UserList.Find(r => r.userName == username);
            return user;
        }

        private void SaveUserScore()
        {
            JsonReadWrite jsonReadWrite = new JsonReadWrite();
            List<User> users = new List<User>();
            users = jsonReadWrite.ReadUsers();
            //var user = users.Find(r => r.userName == CurrentUser.userName);
            users.RemoveAll(r => r.userName == CurrentUser.userName);
            jsonReadWrite.EmptyJsonFile();
            CurrentUser.lastScore = CurrentUser.score;
            CurrentUser.score = 0;
            users.Add(CurrentUser);
            jsonReadWrite.WriteUsers(users);
            scoreStored = true;
        }

        private void GetQuestions()
        {
            JsonReadWrite jsonReadWrite = new JsonReadWrite();
            allQuestions = jsonReadWrite.readQuestions();
        }

        private void SetQuestion()
        {
            question = allQuestions[questionNumber];
            correctAnswer = question.correctAnswer;
            tQuestion.Text = question.question;
            tAnswerA.Text = question.answer1;
            tAnswerB.Text = question.answer2;
            tAnswerC.Text = question.answer3;
            UsedQuestionNumber.Add(questionNumber);
        }

        private void SetNextQuestion()
        {
            if (UsedQuestionNumber.Count == allQuestions.Count)
            {
                MessageBox.Show("No more questions");
                noMoreQuestions = true;
            }
            else
            {
                previousQuestionNumber = questionNumber;
            jump:
                questionNumber = random.Next(0, allQuestions.Count());
                if (UsedQuestionNumber.Contains(questionNumber))
                {
                    questionNumber = random.Next(0, allQuestions.Count());
                    goto jump;
                }
                else
                {
                    question = allQuestions[questionNumber];
                    tQuestion.Text = question.question;
                    correctAnswer = question.correctAnswer;
                    tAnswerA.Text = question.answer1;
                    tAnswerB.Text = question.answer2;
                    tAnswerC.Text = question.answer3;
                    UsedQuestionNumber.Add(questionNumber);
                }
            }
        }

        private void SetPreviousQuestion()
        {
            question = allQuestions[previousQuestionNumber];
            tQuestion.Text = question.question;
            correctAnswer = question.correctAnswer;
            tAnswerA.Text = question.answer1;
            tAnswerB.Text = question.answer2;
            tAnswerC.Text = question.answer3;
        }

        private void SetScore(int points)
        {
            CurrentUser.score += points;
            tScore.Text = CurrentUser.score.ToString();
        }

        private void StopGame()
        {
            if (CurrentUser.score == -500)
            {
                MessageBox.Show("You lost the game");
            }
        }

    }
}
