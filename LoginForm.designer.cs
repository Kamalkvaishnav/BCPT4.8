using System.Drawing;
using System.Windows.Forms;

namespace ConsolFromApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.welcome = new System.Windows.Forms.Label();
            this.pwdBox = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcome.Font = new System.Drawing.Font("Candara", 25.8F, System.Drawing.FontStyle.Italic);
            this.welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.welcome.Location = new System.Drawing.Point(0, 0);
            this.welcome.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(400, 91);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome to BCPT";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pwdBox
            // 
            this.pwdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwdBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pwdBox.Font = new System.Drawing.Font("Candara", 10.2F);
            this.pwdBox.Location = new System.Drawing.Point(104, 95);
            this.pwdBox.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.pwdBox.Name = "pwdBox";
            this.pwdBox.Size = new System.Drawing.Size(221, 21);
            this.pwdBox.TabIndex = 4;
            this.pwdBox.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold);
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(76, 323);
            this.Login.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(250, 40);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold);
            this.ClearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClearButton.Location = new System.Drawing.Point(0, 378);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(115, 30);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click_1);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Exit.Location = new System.Drawing.Point(285, 378);
            this.Exit.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(115, 30);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox5.Location = new System.Drawing.Point(0, 690);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pictureBox5.Size = new System.Drawing.Size(1250, 10);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 106);
            this.panel1.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(408, 84);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(827, 5);
            this.panel4.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(720, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(515, 40);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Budget and Capacity Planning Tool";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 10);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1250, 10);
            this.panel3.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.Login);
            this.panel5.Controls.Add(this.Exit);
            this.panel5.Controls.Add(this.ClearButton);
            this.panel5.Controls.Add(this.welcome);
            this.panel5.Location = new System.Drawing.Point(425, 173);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 408);
            this.panel5.TabIndex = 18;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel13);
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Controls.Add(this.userNameBox);
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.pwdBox);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 150);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(400, 170);
            this.panel7.TabIndex = 11;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel13.Location = new System.Drawing.Point(76, 124);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(250, 2);
            this.panel13.TabIndex = 11;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel12.Location = new System.Drawing.Point(76, 69);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(250, 2);
            this.panel12.TabIndex = 10;
            // 
            // userNameBox
            // 
            this.userNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userNameBox.Font = new System.Drawing.Font("Candara", 10.8F);
            this.userNameBox.Location = new System.Drawing.Point(105, 40);
            this.userNameBox.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(221, 22);
            this.userNameBox.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(76, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(76, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.panel11);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 91);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 59);
            this.panel6.TabIndex = 10;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(350, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(50, 59);
            this.panel11.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(50, 59);
            this.panel10.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Candara", 25.8F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(400, 60);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "LogIn";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 680);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1250, 10);
            this.panel8.TabIndex = 19;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 670);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1250, 10);
            this.panel9.TabIndex = 20;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel14.Location = new System.Drawing.Point(316, 224);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(10, 357);
            this.panel14.TabIndex = 21;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel15.Location = new System.Drawing.Point(316, 214);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(106, 10);
            this.panel15.TabIndex = 22;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel17.Location = new System.Drawing.Point(924, 224);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(10, 357);
            this.panel17.TabIndex = 23;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel16.Location = new System.Drawing.Point(828, 214);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(106, 10);
            this.panel16.TabIndex = 23;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label welcome;
        private TextBox pwdBox;
        private Button Login;
        private Button ClearButton;
        private Button Exit;
        private PictureBox pictureBox5;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel7;
        private Panel panel6;
        private TextBox textBox2;
        private Panel panel8;
        private Panel panel9;
        private Panel panel11;
        private Panel panel10;
        private Panel panel13;
        private Panel panel12;
        private TextBox userNameBox;
        private Panel panel14;
        private Panel panel15;
        private Panel panel17;
        private Panel panel16;
    }
}