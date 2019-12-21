namespace NavyPQS
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pTopPanel = new System.Windows.Forms.Panel();
            this.bCloseApp = new System.Windows.Forms.Button();
            this.bMinimize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lNoAccountQuestion = new System.Windows.Forms.Label();
            this.bSignUp = new System.Windows.Forms.Button();
            this.bSignIn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.pTopPanel);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 425);
            this.panel1.TabIndex = 0;
            // 
            // pTopPanel
            // 
            this.pTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.pTopPanel.Controls.Add(this.bCloseApp);
            this.pTopPanel.Controls.Add(this.bMinimize);
            this.pTopPanel.Controls.Add(this.pictureBox1);
            this.pTopPanel.Controls.Add(this.label1);
            this.pTopPanel.Location = new System.Drawing.Point(3, 3);
            this.pTopPanel.Name = "pTopPanel";
            this.pTopPanel.Size = new System.Drawing.Size(317, 35);
            this.pTopPanel.TabIndex = 1;
            this.pTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTopPanel_MouseDown);
            this.pTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pTopPanel_MouseMove);
            this.pTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pTopPanel_MouseUp);
            // 
            // bCloseApp
            // 
            this.bCloseApp.BackgroundImage = global::NavyPQS.Properties.Resources.icons8_close_window_100;
            this.bCloseApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCloseApp.Location = new System.Drawing.Point(284, 6);
            this.bCloseApp.Name = "bCloseApp";
            this.bCloseApp.Size = new System.Drawing.Size(30, 23);
            this.bCloseApp.TabIndex = 3;
            this.bCloseApp.UseVisualStyleBackColor = true;
            this.bCloseApp.Click += new System.EventHandler(this.bCloseApp_Click);
            // 
            // bMinimize
            // 
            this.bMinimize.BackgroundImage = global::NavyPQS.Properties.Resources.minimizeNormal;
            this.bMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMinimize.Location = new System.Drawing.Point(248, 6);
            this.bMinimize.Name = "bMinimize";
            this.bMinimize.Size = new System.Drawing.Size(30, 23);
            this.bMinimize.TabIndex = 2;
            this.bMinimize.UseVisualStyleBackColor = true;
            this.bMinimize.Click += new System.EventHandler(this.bMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::NavyPQS.Properties.Resources.tick;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 29);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(43, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAVY-DEP-PQS LOGIN";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel5.Controls.Add(this.lNoAccountQuestion);
            this.panel5.Controls.Add(this.bSignUp);
            this.panel5.Controls.Add(this.bSignIn);
            this.panel5.Location = new System.Drawing.Point(3, 321);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(317, 100);
            this.panel5.TabIndex = 1;
            // 
            // lNoAccountQuestion
            // 
            this.lNoAccountQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lNoAccountQuestion.AutoSize = true;
            this.lNoAccountQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lNoAccountQuestion.Location = new System.Drawing.Point(92, 50);
            this.lNoAccountQuestion.Name = "lNoAccountQuestion";
            this.lNoAccountQuestion.Size = new System.Drawing.Size(139, 13);
            this.lNoAccountQuestion.TabIndex = 4;
            this.lNoAccountQuestion.Text = "Don\'t have an account yet?";
            // 
            // bSignUp
            // 
            this.bSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSignUp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bSignUp.Location = new System.Drawing.Point(134, 66);
            this.bSignUp.Name = "bSignUp";
            this.bSignUp.Size = new System.Drawing.Size(55, 23);
            this.bSignUp.TabIndex = 1;
            this.bSignUp.Text = "Sign Up";
            this.bSignUp.UseVisualStyleBackColor = true;
            this.bSignUp.Click += new System.EventHandler(this.bSignUp_Click);
            // 
            // bSignIn
            // 
            this.bSignIn.Location = new System.Drawing.Point(105, 8);
            this.bSignIn.Name = "bSignIn";
            this.bSignIn.Size = new System.Drawing.Size(112, 39);
            this.bSignIn.TabIndex = 0;
            this.bSignIn.Text = "Sign In";
            this.bSignIn.UseVisualStyleBackColor = true;
            this.bSignIn.Click += new System.EventHandler(this.bSignIn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel4.Controls.Add(this.tPassword);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(3, 215);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(317, 100);
            this.panel4.TabIndex = 1;
            // 
            // tPassword
            // 
            this.tPassword.AcceptsReturn = true;
            this.tPassword.AcceptsTab = true;
            this.tPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.tPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tPassword.Location = new System.Drawing.Point(147, 40);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(158, 23);
            this.tPassword.TabIndex = 4;
            this.tPassword.WordWrap = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(31, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel3.Controls.Add(this.tUserName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 100);
            this.panel3.TabIndex = 1;
            // 
            // tUserName
            // 
            this.tUserName.AcceptsReturn = true;
            this.tUserName.AcceptsTab = true;
            this.tUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.tUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tUserName.Location = new System.Drawing.Point(147, 40);
            this.tUserName.Name = "tUserName";
            this.tUserName.Size = new System.Drawing.Size(158, 23);
            this.tUserName.TabIndex = 1;
            this.tUserName.WordWrap = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(31, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 59);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(105, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Log In";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(347, 452);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.pTopPanel.ResumeLayout(false);
            this.pTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pTopPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bSignIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lNoAccountQuestion;
        private System.Windows.Forms.Button bSignUp;
        private System.Windows.Forms.Button bCloseApp;
        private System.Windows.Forms.Button bMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tPassword;
    }
}