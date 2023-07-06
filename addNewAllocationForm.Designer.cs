namespace BCPT
{
    partial class addNewAllocationForm
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.allocationTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.yearCb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.monthCb = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gocTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.featureTeamTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.projectManagerTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.soeidCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ptsidCb = new System.Windows.Forms.ComboBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 61);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(23, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Allocation";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 449);
            this.panel2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(357, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(275, 45);
            this.button3.TabIndex = 13;
            this.button3.Text = "CANCEL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(30, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 45);
            this.button2.TabIndex = 12;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.allocationTextBox);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.yearCb);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.monthCb);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 257);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(713, 100);
            this.panel5.TabIndex = 11;
            // 
            // allocationTextBox
            // 
            this.allocationTextBox.Location = new System.Drawing.Point(469, 50);
            this.allocationTextBox.Name = "allocationTextBox";
            this.allocationTextBox.Size = new System.Drawing.Size(163, 22);
            this.allocationTextBox.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(465, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 21);
            this.label12.TabIndex = 15;
            this.label12.Text = "Allocation";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(237, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "Year";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // yearCb
            // 
            this.yearCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.yearCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.yearCb.FormattingEnabled = true;
            this.yearCb.Location = new System.Drawing.Point(239, 49);
            this.yearCb.Name = "yearCb";
            this.yearCb.Size = new System.Drawing.Size(165, 24);
            this.yearCb.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 21);
            this.label11.TabIndex = 11;
            this.label11.Text = "Month";
            // 
            // monthCb
            // 
            this.monthCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.monthCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.monthCb.FormattingEnabled = true;
            this.monthCb.Location = new System.Drawing.Point(30, 49);
            this.monthCb.Name = "monthCb";
            this.monthCb.Size = new System.Drawing.Size(165, 24);
            this.monthCb.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.locationTextBox);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.gocTextBox);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.featureTeamTextBox);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.projectManagerTextBox);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.projectNameTextBox);
            this.panel4.Controls.Add(this.nameTextBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(713, 169);
            this.panel4.TabIndex = 10;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(467, 122);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(165, 22);
            this.locationTextBox.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(465, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 21);
            this.label9.TabIndex = 24;
            this.label9.Text = "Location";
            // 
            // gocTextBox
            // 
            this.gocTextBox.Location = new System.Drawing.Point(239, 122);
            this.gocTextBox.Name = "gocTextBox";
            this.gocTextBox.Size = new System.Drawing.Size(165, 22);
            this.gocTextBox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(237, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "GOC";
            // 
            // featureTeamTextBox
            // 
            this.featureTeamTextBox.Location = new System.Drawing.Point(30, 122);
            this.featureTeamTextBox.Name = "featureTeamTextBox";
            this.featureTeamTextBox.Size = new System.Drawing.Size(165, 22);
            this.featureTeamTextBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Feature Team";
            // 
            // projectManagerTextBox
            // 
            this.projectManagerTextBox.Location = new System.Drawing.Point(469, 50);
            this.projectManagerTextBox.Name = "projectManagerTextBox";
            this.projectManagerTextBox.Size = new System.Drawing.Size(163, 22);
            this.projectManagerTextBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(465, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Project Manager";
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Location = new System.Drawing.Point(239, 50);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(165, 22);
            this.projectNameTextBox.TabIndex = 15;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(32, 50);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(163, 22);
            this.nameTextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Project Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.soeidCb);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.ptsidCb);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(713, 88);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(469, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "LOOKUP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "SOEID";
            // 
            // soeidCb
            // 
            this.soeidCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.soeidCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.soeidCb.FormattingEnabled = true;
            this.soeidCb.Location = new System.Drawing.Point(239, 43);
            this.soeidCb.Name = "soeidCb";
            this.soeidCb.Size = new System.Drawing.Size(165, 24);
            this.soeidCb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "PTSID";
            // 
            // ptsidCb
            // 
            this.ptsidCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ptsidCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ptsidCb.FormattingEnabled = true;
            this.ptsidCb.Location = new System.Drawing.Point(30, 43);
            this.ptsidCb.Name = "ptsidCb";
            this.ptsidCb.Size = new System.Drawing.Size(165, 24);
            this.ptsidCb.TabIndex = 6;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // addNewAllocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(723, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "addNewAllocationForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addNewAllocationForm";
            this.Load += new System.EventHandler(this.addNewAllocationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox soeidCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ptsidCb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox featureTeamTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox projectManagerTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox gocTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox yearCb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox monthCb;
        private System.Windows.Forms.TextBox allocationTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}