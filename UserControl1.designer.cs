﻿namespace WindowsFormsApp2
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button_modify = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox_p_type = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.jpg");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "view.png");
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ImageKey = "(none)";
            this.button2.ImageList = this.imageList2;
            this.button2.Location = new System.Drawing.Point(194, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "View all Projects";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "filter.jpg");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1570, 526);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(412, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(629, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(1307, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_modify
            // 
            this.button_modify.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.button_modify.Location = new System.Drawing.Point(1403, 150);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(75, 23);
            this.button_modify.TabIndex = 11;
            this.button_modify.Text = "Modify";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.Click += new System.EventHandler(this.button5_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(1496, 150);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Archive";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(1411, 84);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 34);
            this.button6.TabIndex = 13;
            this.button6.Text = "Archived projects";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1189, 150);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "Unarchive";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 49);
            this.label2.TabIndex = 15;
            this.label2.Text = "Project Master";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(23, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add New Project";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.comboBox_p_type);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button_modify);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1580, 179);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 179);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(1580, 536);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1580, 10);
            this.panel3.TabIndex = 19;
            // 
            // comboBox_p_type
            // 
            this.comboBox_p_type.FormattingEnabled = true;
            this.comboBox_p_type.Location = new System.Drawing.Point(475, 148);
            this.comboBox_p_type.Name = "comboBox_p_type";
            this.comboBox_p_type.Size = new System.Drawing.Size(121, 24);
            this.comboBox_p_type.TabIndex = 17;
            this.comboBox_p_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_p_type_SelectedIndexChanged);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(475, 119);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(121, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "Project Type";
            this.button8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.button9.Location = new System.Drawing.Point(23, 125);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(170, 23);
            this.button9.TabIndex = 19;
            this.button9.Text = "Search Description";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1580, 715);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox_p_type;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
    }
}
