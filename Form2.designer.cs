namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_ptsid = new System.Windows.Forms.Label();
            this.label_date2 = new System.Windows.Forms.Label();
            this.label_date1 = new System.Windows.Forms.Label();
            this.label_cat = new System.Windows.Forms.Label();
            this.label_pi = new System.Windows.Forms.Label();
            this.label_pm = new System.Windows.Forms.Label();
            this.label_pt = new System.Windows.Forms.Label();
            this.label_pd = new System.Windows.Forms.Label();
            this.label_net0 = new System.Windows.Forms.Label();
            this.PTSID = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.PM = new System.Windows.Forms.ComboBox();
            this.submit_newproject = new System.Windows.Forms.Button();
            this.piac = new System.Windows.Forms.ComboBox();
            this.progId = new System.Windows.Forms.ComboBox();
            this.projecttype = new System.Windows.Forms.ComboBox();
            this.NetL0 = new System.Windows.Forms.TextBox();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.label_cntry = new System.Windows.Forms.Label();
            this.country_name = new System.Windows.Forms.ComboBox();
            this.label_product = new System.Windows.Forms.Label();
            this.product_name = new System.Windows.Forms.ComboBox();
            this.label_status = new System.Windows.Forms.Label();
            this.product_status = new System.Windows.Forms.ComboBox();
            this.SecoreL1 = new System.Windows.Forms.TextBox();
            this.label_net1 = new System.Windows.Forms.Label();
            this.label_sec0 = new System.Windows.Forms.Label();
            this.SecoreL0 = new System.Windows.Forms.TextBox();
            this.label_sec1 = new System.Windows.Forms.Label();
            this.NetL1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW PROJECT";
            // 
            // label_ptsid
            // 
            this.label_ptsid.AutoSize = true;
            this.label_ptsid.Location = new System.Drawing.Point(107, 121);
            this.label_ptsid.Name = "label_ptsid";
            this.label_ptsid.Size = new System.Drawing.Size(50, 16);
            this.label_ptsid.TabIndex = 1;
            this.label_ptsid.Text = "PTS ID";
            this.label_ptsid.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_date2
            // 
            this.label_date2.AutoSize = true;
            this.label_date2.Location = new System.Drawing.Point(107, 425);
            this.label_date2.Name = "label_date2";
            this.label_date2.Size = new System.Drawing.Size(43, 16);
            this.label_date2.TabIndex = 2;
            this.label_date2.Text = "Date2";
            // 
            // label_date1
            // 
            this.label_date1.AutoSize = true;
            this.label_date1.Location = new System.Drawing.Point(107, 388);
            this.label_date1.Name = "label_date1";
            this.label_date1.Size = new System.Drawing.Size(43, 16);
            this.label_date1.TabIndex = 3;
            this.label_date1.Text = "Date1";
            this.label_date1.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_cat
            // 
            this.label_cat.AutoSize = true;
            this.label_cat.Location = new System.Drawing.Point(107, 345);
            this.label_cat.Name = "label_cat";
            this.label_cat.Size = new System.Drawing.Size(62, 16);
            this.label_cat.TabIndex = 4;
            this.label_cat.Text = "Category";
            this.label_cat.Click += new System.EventHandler(this.label5_Click);
            // 
            // label_pi
            // 
            this.label_pi.AutoSize = true;
            this.label_pi.Location = new System.Drawing.Point(107, 304);
            this.label_pi.Name = "label_pi";
            this.label_pi.Size = new System.Drawing.Size(50, 16);
            this.label_pi.TabIndex = 5;
            this.label_pi.Text = "Prog Id";
            // 
            // label_pm
            // 
            this.label_pm.AutoSize = true;
            this.label_pm.Location = new System.Drawing.Point(107, 264);
            this.label_pm.Name = "label_pm";
            this.label_pm.Size = new System.Drawing.Size(27, 16);
            this.label_pm.TabIndex = 6;
            this.label_pm.Text = "PM";
            // 
            // label_pt
            // 
            this.label_pt.AutoSize = true;
            this.label_pt.Location = new System.Drawing.Point(107, 217);
            this.label_pt.Name = "label_pt";
            this.label_pt.Size = new System.Drawing.Size(78, 16);
            this.label_pt.TabIndex = 7;
            this.label_pt.Text = "Project type";
            // 
            // label_pd
            // 
            this.label_pd.AutoSize = true;
            this.label_pd.Location = new System.Drawing.Point(107, 165);
            this.label_pd.Name = "label_pd";
            this.label_pd.Size = new System.Drawing.Size(113, 16);
            this.label_pd.TabIndex = 8;
            this.label_pd.Text = "Project Decription";
            // 
            // label_net0
            // 
            this.label_net0.AutoSize = true;
            this.label_net0.Location = new System.Drawing.Point(111, 711);
            this.label_net0.Name = "label_net0";
            this.label_net0.Size = new System.Drawing.Size(55, 16);
            this.label_net0.TabIndex = 9;
            this.label_net0.Text = ".NET L0";
            this.label_net0.Click += new System.EventHandler(this.label10_Click);
            // 
            // PTSID
            // 
            this.PTSID.Location = new System.Drawing.Point(265, 115);
            this.PTSID.Name = "PTSID";
            this.PTSID.Size = new System.Drawing.Size(100, 22);
            this.PTSID.TabIndex = 11;
            this.PTSID.TextChanged += new System.EventHandler(this.PTSID_TextChanged);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(265, 162);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(469, 22);
            this.Description.TabIndex = 19;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // PM
            // 
            this.PM.FormattingEnabled = true;
            this.PM.Items.AddRange(new object[] {
            "choice1",
            "choice2",
            "choice3",
            "choice4"});
            this.PM.Location = new System.Drawing.Point(265, 255);
            this.PM.Name = "PM";
            this.PM.Size = new System.Drawing.Size(121, 24);
            this.PM.TabIndex = 22;
            // 
            // submit_newproject
            // 
            this.submit_newproject.Location = new System.Drawing.Point(599, 810);
            this.submit_newproject.Name = "submit_newproject";
            this.submit_newproject.Size = new System.Drawing.Size(75, 23);
            this.submit_newproject.TabIndex = 23;
            this.submit_newproject.Text = "Submit";
            this.submit_newproject.UseVisualStyleBackColor = true;
            this.submit_newproject.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // piac
            // 
            this.piac.FormattingEnabled = true;
            this.piac.Items.AddRange(new object[] {
            "choice1",
            "choice2",
            "choice3",
            "choice4"});
            this.piac.Location = new System.Drawing.Point(265, 342);
            this.piac.Name = "piac";
            this.piac.Size = new System.Drawing.Size(121, 24);
            this.piac.TabIndex = 24;
            // 
            // progId
            // 
            this.progId.FormattingEnabled = true;
            this.progId.Items.AddRange(new object[] {
            "choice1",
            "choice2",
            "choice3",
            "choice4"});
            this.progId.Location = new System.Drawing.Point(265, 296);
            this.progId.Name = "progId";
            this.progId.Size = new System.Drawing.Size(121, 24);
            this.progId.TabIndex = 25;
            // 
            // projecttype
            // 
            this.projecttype.FormattingEnabled = true;
            this.projecttype.Items.AddRange(new object[] {
            "choice1",
            "choice2",
            "choice3",
            "choice4"});
            this.projecttype.Location = new System.Drawing.Point(265, 217);
            this.projecttype.Name = "projecttype";
            this.projecttype.Size = new System.Drawing.Size(121, 24);
            this.projecttype.TabIndex = 26;
            // 
            // NetL0
            // 
            this.NetL0.Location = new System.Drawing.Point(269, 706);
            this.NetL0.Name = "NetL0";
            this.NetL0.Size = new System.Drawing.Size(100, 22);
            this.NetL0.TabIndex = 27;
            this.NetL0.TextChanged += new System.EventHandler(this.NetL0_TextChanged);
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(265, 391);
            this.date1.MinDate = new System.DateTime(2023, 7, 6, 0, 0, 0, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(200, 22);
            this.date1.TabIndex = 28;
            this.date1.Value = new System.DateTime(2023, 7, 6, 0, 0, 0, 0);
            this.date1.ValueChanged += new System.EventHandler(this.date1_ValueChanged);
            // 
            // date2
            // 
            this.date2.Location = new System.Drawing.Point(265, 425);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(200, 22);
            this.date2.TabIndex = 29;
            this.date2.Value = new System.DateTime(2023, 7, 7, 0, 0, 0, 0);
            this.date2.ValueChanged += new System.EventHandler(this.date2_ValueChanged);
            // 
            // label_cntry
            // 
            this.label_cntry.AutoSize = true;
            this.label_cntry.Location = new System.Drawing.Point(107, 473);
            this.label_cntry.Name = "label_cntry";
            this.label_cntry.Size = new System.Drawing.Size(52, 16);
            this.label_cntry.TabIndex = 30;
            this.label_cntry.Text = "Country";
            // 
            // country_name
            // 
            this.country_name.FormattingEnabled = true;
            this.country_name.Items.AddRange(new object[] {
            "choice1",
            "choice2",
            "choice3",
            "choice4"});
            this.country_name.Location = new System.Drawing.Point(262, 473);
            this.country_name.Name = "country_name";
            this.country_name.Size = new System.Drawing.Size(121, 24);
            this.country_name.TabIndex = 31;
            // 
            // label_product
            // 
            this.label_product.AutoSize = true;
            this.label_product.Location = new System.Drawing.Point(107, 518);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(53, 16);
            this.label_product.TabIndex = 32;
            this.label_product.Text = "Product";
            // 
            // product_name
            // 
            this.product_name.FormattingEnabled = true;
            this.product_name.Items.AddRange(new object[] {
            "choice1",
            "choice2",
            "choice3",
            "choice4"});
            this.product_name.Location = new System.Drawing.Point(262, 518);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(121, 24);
            this.product_name.TabIndex = 33;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(107, 562);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(44, 16);
            this.label_status.TabIndex = 34;
            this.label_status.Text = "Status";
            this.label_status.Click += new System.EventHandler(this.label14_Click);
            // 
            // product_status
            // 
            this.product_status.FormattingEnabled = true;
            this.product_status.Items.AddRange(new object[] {
            "choice1",
            "choice2",
            "choice3",
            "choice4"});
            this.product_status.Location = new System.Drawing.Point(262, 554);
            this.product_status.Name = "product_status";
            this.product_status.Size = new System.Drawing.Size(121, 24);
            this.product_status.TabIndex = 35;
            // 
            // SecoreL1
            // 
            this.SecoreL1.Location = new System.Drawing.Point(265, 655);
            this.SecoreL1.Name = "SecoreL1";
            this.SecoreL1.Size = new System.Drawing.Size(100, 22);
            this.SecoreL1.TabIndex = 37;
            this.SecoreL1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_net1
            // 
            this.label_net1.AutoSize = true;
            this.label_net1.Location = new System.Drawing.Point(111, 752);
            this.label_net1.Name = "label_net1";
            this.label_net1.Size = new System.Drawing.Size(55, 16);
            this.label_net1.TabIndex = 38;
            this.label_net1.Text = ".NET L1";
            // 
            // label_sec0
            // 
            this.label_sec0.AutoSize = true;
            this.label_sec0.Location = new System.Drawing.Point(107, 616);
            this.label_sec0.Name = "label_sec0";
            this.label_sec0.Size = new System.Drawing.Size(68, 16);
            this.label_sec0.TabIndex = 10;
            this.label_sec0.Text = "Secore L0";
            // 
            // SecoreL0
            // 
            this.SecoreL0.Location = new System.Drawing.Point(265, 610);
            this.SecoreL0.Name = "SecoreL0";
            this.SecoreL0.Size = new System.Drawing.Size(100, 22);
            this.SecoreL0.TabIndex = 12;
            // 
            // label_sec1
            // 
            this.label_sec1.AutoSize = true;
            this.label_sec1.Location = new System.Drawing.Point(110, 661);
            this.label_sec1.Name = "label_sec1";
            this.label_sec1.Size = new System.Drawing.Size(68, 16);
            this.label_sec1.TabIndex = 36;
            this.label_sec1.Text = "Secore L1";
            this.label_sec1.Click += new System.EventHandler(this.label15_Click);
            // 
            // NetL1
            // 
            this.NetL1.Location = new System.Drawing.Point(269, 752);
            this.NetL1.Name = "NetL1";
            this.NetL1.Size = new System.Drawing.Size(100, 22);
            this.NetL1.TabIndex = 39;
            this.NetL1.TextChanged += new System.EventHandler(this.NetL1_TextChanged);
            // 
            // Form2
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 929);
            this.Controls.Add(this.NetL1);
            this.Controls.Add(this.label_net1);
            this.Controls.Add(this.SecoreL1);
            this.Controls.Add(this.label_sec1);
            this.Controls.Add(this.product_status);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.product_name);
            this.Controls.Add(this.label_product);
            this.Controls.Add(this.country_name);
            this.Controls.Add(this.label_cntry);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.NetL0);
            this.Controls.Add(this.projecttype);
            this.Controls.Add(this.progId);
            this.Controls.Add(this.piac);
            this.Controls.Add(this.submit_newproject);
            this.Controls.Add(this.PM);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.SecoreL0);
            this.Controls.Add(this.PTSID);
            this.Controls.Add(this.label_sec0);
            this.Controls.Add(this.label_net0);
            this.Controls.Add(this.label_pd);
            this.Controls.Add(this.label_pt);
            this.Controls.Add(this.label_pm);
            this.Controls.Add(this.label_pi);
            this.Controls.Add(this.label_cat);
            this.Controls.Add(this.label_date1);
            this.Controls.Add(this.label_date2);
            this.Controls.Add(this.label_ptsid);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ptsid;
        private System.Windows.Forms.Label label_date2;
        private System.Windows.Forms.Label label_date1;
        private System.Windows.Forms.Label label_cat;
        private System.Windows.Forms.Label label_pi;
        private System.Windows.Forms.Label label_pm;
        private System.Windows.Forms.Label label_pt;
        private System.Windows.Forms.Label label_pd;
        private System.Windows.Forms.Label label_net0;
        private System.Windows.Forms.TextBox PTSID;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox PM;
        private System.Windows.Forms.Button submit_newproject;
        private System.Windows.Forms.ComboBox piac;
        private System.Windows.Forms.ComboBox progId;
        private System.Windows.Forms.ComboBox projecttype;
        private System.Windows.Forms.TextBox NetL0;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Label label_cntry;
        private System.Windows.Forms.ComboBox country_name;
        private System.Windows.Forms.Label label_product;
        private System.Windows.Forms.ComboBox product_name;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ComboBox product_status;
        private System.Windows.Forms.TextBox SecoreL1;
        private System.Windows.Forms.Label label_net1;
        private System.Windows.Forms.Label label_sec0;
        private System.Windows.Forms.TextBox SecoreL0;
        private System.Windows.Forms.Label label_sec1;
        private System.Windows.Forms.TextBox NetL1;
    }
}