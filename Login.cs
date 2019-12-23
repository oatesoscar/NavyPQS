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
    public partial class Login : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private bool isOK;
        User User = new User();

        public Login()
        {
            InitializeComponent();
        }

        private void bCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pTopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pTopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void pTopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void bMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bSignIn_Click(object sender, EventArgs e)
        {
            CheckFields();
            if (isOK)
            {
                FindUser();
            }
        }

        private void bSignUp_Click(object sender, EventArgs e)
        {
            CheckFields();
            if (isOK == true)
            {
                CreateUser();
                isOK = false;
                this.Hide();
                Questions questions = new Questions(User.userName);
                questions.Show();
            }
        }

        public void CreateUser()
        {
            CheckFields();
            if (isOK == true)
            {
                if (tUserName.Text == "Admin" || tUserName.Text == "admin")
                {
                    User user = new User()
                    {
                        userName = tUserName.Text,
                        password = tPassword.Text,
                        isAdmin = true
                    };
                    JsonReadWrite jsonReadWrite = new JsonReadWrite();
                    jsonReadWrite.AddUser(user);
                    User = user;
                }
                else
                {
                    User user = new User()
                    {
                        userName = tUserName.Text,
                        password = tPassword.Text,
                    };
                    JsonReadWrite jsonReadWrite = new JsonReadWrite();
                    jsonReadWrite.AddUser(user);
                    User = user;
                }

            }
        }

        private void FindUser()
        {
            JsonReadWrite jsonReadWrite = new JsonReadWrite();
            var UserList = jsonReadWrite.ReadUsers();
            var user = UserList.Find(r => r.userName == tUserName.Text);
            if (user == null)
            {
                isOK = false;
                MessageBox.Show("this user doesn't exist... Create one instead");
                this.Show();                
            }
            else if (tPassword.Text != user.password)
            {
                MessageBox.Show("Wrong password");
                this.Show();
                isOK = false;
            }
            else
            {
                User = user;
                if (User.isAdmin == true)
                {
                    AdminPanel adminPanel = new AdminPanel();
                    this.Hide();
                    adminPanel.Show();
                }
                else
                {
                    Questions questions = new Questions(User.userName);
                    this.Hide();
                    questions.Show();
                }

            }
            
        }

        private void CheckFields()
        {
            // Checks if both fields are empty.
            if (tUserName.Text == string.Empty)
            {
                MessageBox.Show("Enter UserName naa");
                this.Show();
                isOK = false;
            }
            else if (tPassword.Text == string.Empty)
            {
                MessageBox.Show("Enter Password naa");
                this.Show();
                isOK = false;
            }
            else if (tUserName.Text == string.Empty && tPassword.Text == string.Empty)
            {
                MessageBox.Show("Enter something naa");
                this.Show();
                isOK = false;
            }
            else
            {
                 isOK = true;
            }
        }

 
    }
}
