namespace NavyPQS
{
    partial class AdminPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bSelectTxtFilePath = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bComplete = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bOpenTxtFile = new System.Windows.Forms.Button();
            this.tTextFilePath = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN PANEL";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.bSelectTxtFilePath);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bOpenTxtFile);
            this.panel2.Controls.Add(this.tTextFilePath);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 172);
            this.panel2.TabIndex = 1;
            // 
            // bSelectTxtFilePath
            // 
            this.bSelectTxtFilePath.Location = new System.Drawing.Point(206, 47);
            this.bSelectTxtFilePath.Name = "bSelectTxtFilePath";
            this.bSelectTxtFilePath.Size = new System.Drawing.Size(75, 30);
            this.bSelectTxtFilePath.TabIndex = 9;
            this.bSelectTxtFilePath.Text = "Select Path";
            this.bSelectTxtFilePath.UseVisualStyleBackColor = true;
            this.bSelectTxtFilePath.Click += new System.EventHandler(this.bSelectTxtFilePath_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bComplete);
            this.panel3.Controls.Add(this.bCancel);
            this.panel3.Location = new System.Drawing.Point(3, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 50);
            this.panel3.TabIndex = 8;
            // 
            // bComplete
            // 
            this.bComplete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bComplete.Location = new System.Drawing.Point(3, 3);
            this.bComplete.Name = "bComplete";
            this.bComplete.Size = new System.Drawing.Size(97, 44);
            this.bComplete.TabIndex = 6;
            this.bComplete.Text = "Complete";
            this.bComplete.UseVisualStyleBackColor = true;
            this.bComplete.Click += new System.EventHandler(this.bComplete_Click);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.Location = new System.Drawing.Point(181, 3);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(97, 44);
            this.bCancel.TabIndex = 7;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Text File Path";
            // 
            // bOpenTxtFile
            // 
            this.bOpenTxtFile.Location = new System.Drawing.Point(88, 47);
            this.bOpenTxtFile.Name = "bOpenTxtFile";
            this.bOpenTxtFile.Size = new System.Drawing.Size(70, 30);
            this.bOpenTxtFile.TabIndex = 1;
            this.bOpenTxtFile.Text = "Open file";
            this.bOpenTxtFile.UseVisualStyleBackColor = true;
            this.bOpenTxtFile.Click += new System.EventHandler(this.bOpenTxtFile_Click);
            // 
            // tTextFilePath
            // 
            this.tTextFilePath.Enabled = false;
            this.tTextFilePath.Location = new System.Drawing.Point(88, 21);
            this.tTextFilePath.Name = "tTextFilePath";
            this.tTextFilePath.ReadOnly = true;
            this.tTextFilePath.Size = new System.Drawing.Size(193, 20);
            this.tTextFilePath.TabIndex = 0;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(311, 305);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bOpenTxtFile;
        private System.Windows.Forms.TextBox tTextFilePath;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bComplete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bSelectTxtFilePath;
    }
}