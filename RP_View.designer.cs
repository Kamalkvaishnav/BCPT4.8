using System.Windows.Forms;

namespace ConsolFromApp
{
    partial class RP_View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP_View));
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gocCb = new System.Windows.Forms.ComboBox();
            this.soeidCb = new System.Windows.Forms.ComboBox();
            this.rnCb = new System.Windows.Forms.ComboBox();
            this.rmCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rpViewDataGrid = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpViewDataGrid)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1342, 127);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.SearchBtn);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.gocCb);
            this.panel5.Controls.Add(this.soeidCb);
            this.panel5.Controls.Add(this.rnCb);
            this.panel5.Controls.Add(this.rmCb);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1342, 74);
            this.panel5.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1007, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(917, 25);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(84, 34);
            this.SearchBtn.TabIndex = 9;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(713, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "GOC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(489, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "SOEID\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resource Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resource Manager";
            // 
            // gocCb
            // 
            this.gocCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.gocCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.gocCb.FormattingEnabled = true;
            this.gocCb.Location = new System.Drawing.Point(715, 35);
            this.gocCb.Name = "gocCb";
            this.gocCb.Size = new System.Drawing.Size(165, 24);
            this.gocCb.TabIndex = 3;
            // 
            // soeidCb
            // 
            this.soeidCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.soeidCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.soeidCb.FormattingEnabled = true;
            this.soeidCb.Location = new System.Drawing.Point(491, 35);
            this.soeidCb.Name = "soeidCb";
            this.soeidCb.Size = new System.Drawing.Size(165, 24);
            this.soeidCb.TabIndex = 2;
            // 
            // rnCb
            // 
            this.rnCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rnCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rnCb.FormattingEnabled = true;
            this.rnCb.Location = new System.Drawing.Point(262, 35);
            this.rnCb.Name = "rnCb";
            this.rnCb.Size = new System.Drawing.Size(165, 24);
            this.rnCb.TabIndex = 1;
            // 
            // rmCb
            // 
            this.rmCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rmCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rmCb.FormattingEnabled = true;
            this.rmCb.Location = new System.Drawing.Point(34, 35);
            this.rmCb.Name = "rmCb";
            this.rmCb.Size = new System.Drawing.Size(165, 24);
            this.rmCb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(23, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resource Plan View (RP View)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1342, 448);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 8);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel4.Size = new System.Drawing.Size(1342, 440);
            this.panel4.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(5, 4);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1328, 428);
            this.panel7.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.rpViewDataGrid);
            this.panel8.Controls.Add(this.panel6);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1328, 428);
            this.panel8.TabIndex = 2;
            // 
            // rpViewDataGrid
            // 
            this.rpViewDataGrid.AllowDrop = true;
            this.rpViewDataGrid.AllowUserToAddRows = false;
            this.rpViewDataGrid.AllowUserToDeleteRows = false;
            this.rpViewDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rpViewDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.rpViewDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rpViewDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.rpViewDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rpViewDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rpViewDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rpViewDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rpViewDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpViewDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.rpViewDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rpViewDataGrid.Location = new System.Drawing.Point(0, 0);
            this.rpViewDataGrid.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.rpViewDataGrid.Name = "rpViewDataGrid";
            this.rpViewDataGrid.RowHeadersWidth = 10;
            this.rpViewDataGrid.Size = new System.Drawing.Size(1328, 359);
            this.rpViewDataGrid.TabIndex = 0;
            this.rpViewDataGrid.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.button1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 359);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 8, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.panel6.Size = new System.Drawing.Size(1328, 69);
            this.panel6.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1132, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(186, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "      Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1342, 8);
            this.panel3.TabIndex = 3;
            // 
            // RP_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RP_View";
            this.Size = new System.Drawing.Size(1342, 575);
            this.Load += new System.EventHandler(this.RP_View_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rpViewDataGrid)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Panel panel1;
        private Label label1;
        private Panel panel5;
        private ComboBox gocCb;
        private ComboBox soeidCb;
        private ComboBox rnCb;
        private ComboBox rmCb;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private Button SearchBtn;
        private Button button2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel7;
        private Panel panel8;
        private DataGridView rpViewDataGrid;
        private Panel panel6;
        private Button button1;
    }
}
