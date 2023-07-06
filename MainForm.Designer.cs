using System.Drawing;
using System.Windows.Forms;

namespace ConsolFromApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.slidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.slidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuIconButton = new System.Windows.Forms.PictureBox();
            this.resourceMasterBtn = new System.Windows.Forms.Button();
            this.projectMasterBtn = new System.Windows.Forms.Button();
            this.allocationMasterBtn = new System.Windows.Forms.Button();
            this.acViewBtn = new System.Windows.Forms.Button();
            this.rpViewBtn = new System.Windows.Forms.Button();
            this.trsViewBtn = new System.Windows.Forms.Button();
            this.headCountBtn = new System.Windows.Forms.Button();
            this.gocMasterBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.headCountUserControl11 = new ConsolFromApp.headCountUserControl1();
            this.trsView1 = new ConsolFromApp.TRSView();
            this.avaiCapView1 = new ConsolFromApp.avaiCapView();
            this.homeView11 = new ConsolFromApp.homeView1();
            this.rP_View2 = new ConsolFromApp.RP_View();
            this.allocation_Master1 = new BCPT.Allocation_Master();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.slidebar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuIconButton)).BeginInit();
            this.SuspendLayout();
            // 
            // slidebarTimer
            // 
            this.slidebarTimer.Interval = 5;
            this.slidebarTimer.Tick += new System.EventHandler(this.slidebarTimer_Tick_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1444, 10);
            this.panel3.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1444, 10);
            this.panel1.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1444, 106);
            this.panel4.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(38)))), ((int)(((byte)(28)))));
            this.label2.Location = new System.Drawing.Point(1364, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Log Out";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1371, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Location = new System.Drawing.Point(1349, 23);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 60);
            this.panel8.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(38)))), ((int)(((byte)(28)))));
            this.panel5.Location = new System.Drawing.Point(503, 84);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(827, 5);
            this.panel5.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(818, 33);
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
            // panel6
            // 
            this.panel6.Controls.Add(this.mainPanel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 126);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1444, 652);
            this.panel6.TabIndex = 21;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.allocation_Master1);
            this.mainPanel.Controls.Add(this.headCountUserControl11);
            this.mainPanel.Controls.Add(this.trsView1);
            this.mainPanel.Controls.Add(this.avaiCapView1);
            this.mainPanel.Controls.Add(this.homeView11);
            this.mainPanel.Controls.Add(this.rP_View2);
            this.mainPanel.Controls.Add(this.slidebar);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1444, 652);
            this.mainPanel.TabIndex = 0;
            // 
            // slidebar
            // 
            this.slidebar.BackColor = System.Drawing.Color.White;
            this.slidebar.Controls.Add(this.panelMenu);
            this.slidebar.Controls.Add(this.resourceMasterBtn);
            this.slidebar.Controls.Add(this.projectMasterBtn);
            this.slidebar.Controls.Add(this.allocationMasterBtn);
            this.slidebar.Controls.Add(this.acViewBtn);
            this.slidebar.Controls.Add(this.rpViewBtn);
            this.slidebar.Controls.Add(this.trsViewBtn);
            this.slidebar.Controls.Add(this.headCountBtn);
            this.slidebar.Controls.Add(this.gocMasterBtn);
            this.slidebar.Controls.Add(this.exitBtn);
            this.slidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidebar.Location = new System.Drawing.Point(0, 0);
            this.slidebar.MaximumSize = new System.Drawing.Size(257, 702);
            this.slidebar.MinimumSize = new System.Drawing.Size(70, 600);
            this.slidebar.Name = "slidebar";
            this.slidebar.Size = new System.Drawing.Size(257, 652);
            this.slidebar.TabIndex = 25;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.menuIconButton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(3, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 70);
            this.panelMenu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(85, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // menuIconButton
            // 
            this.menuIconButton.Image = ((System.Drawing.Image)(resources.GetObject("menuIconButton.Image")));
            this.menuIconButton.Location = new System.Drawing.Point(11, 17);
            this.menuIconButton.Name = "menuIconButton";
            this.menuIconButton.Size = new System.Drawing.Size(46, 37);
            this.menuIconButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuIconButton.TabIndex = 0;
            this.menuIconButton.TabStop = false;
            this.menuIconButton.Click += new System.EventHandler(this.menuIconButton_Click_1);
            // 
            // resourceMasterBtn
            // 
            this.resourceMasterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.resourceMasterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.resourceMasterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resourceMasterBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.resourceMasterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resourceMasterBtn.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold);
            this.resourceMasterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.resourceMasterBtn.Image = ((System.Drawing.Image)(resources.GetObject("resourceMasterBtn.Image")));
            this.resourceMasterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resourceMasterBtn.Location = new System.Drawing.Point(3, 79);
            this.resourceMasterBtn.Name = "resourceMasterBtn";
            this.resourceMasterBtn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.resourceMasterBtn.Size = new System.Drawing.Size(250, 54);
            this.resourceMasterBtn.TabIndex = 26;
            this.resourceMasterBtn.Text = "Resource Master";
            this.resourceMasterBtn.UseVisualStyleBackColor = false;
            // 
            // projectMasterBtn
            // 
            this.projectMasterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.projectMasterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.projectMasterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.projectMasterBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectMasterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.projectMasterBtn.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold);
            this.projectMasterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.projectMasterBtn.Image = ((System.Drawing.Image)(resources.GetObject("projectMasterBtn.Image")));
            this.projectMasterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.projectMasterBtn.Location = new System.Drawing.Point(3, 139);
            this.projectMasterBtn.Name = "projectMasterBtn";
            this.projectMasterBtn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.projectMasterBtn.Size = new System.Drawing.Size(250, 54);
            this.projectMasterBtn.TabIndex = 27;
            this.projectMasterBtn.Text = "Project Master";
            this.projectMasterBtn.UseVisualStyleBackColor = false;
            // 
            // allocationMasterBtn
            // 
            this.allocationMasterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.allocationMasterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.allocationMasterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allocationMasterBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.allocationMasterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.allocationMasterBtn.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold);
            this.allocationMasterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.allocationMasterBtn.Image = ((System.Drawing.Image)(resources.GetObject("allocationMasterBtn.Image")));
            this.allocationMasterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allocationMasterBtn.Location = new System.Drawing.Point(3, 199);
            this.allocationMasterBtn.Name = "allocationMasterBtn";
            this.allocationMasterBtn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.allocationMasterBtn.Size = new System.Drawing.Size(250, 54);
            this.allocationMasterBtn.TabIndex = 28;
            this.allocationMasterBtn.Text = "Allocation Master";
            this.allocationMasterBtn.UseVisualStyleBackColor = false;
            this.allocationMasterBtn.Click += new System.EventHandler(this.allocationMasterBtn_Click);
            // 
            // acViewBtn
            // 
            this.acViewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.acViewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.acViewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acViewBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.acViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.acViewBtn.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold);
            this.acViewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.acViewBtn.Image = ((System.Drawing.Image)(resources.GetObject("acViewBtn.Image")));
            this.acViewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.acViewBtn.Location = new System.Drawing.Point(3, 259);
            this.acViewBtn.Name = "acViewBtn";
            this.acViewBtn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.acViewBtn.Size = new System.Drawing.Size(250, 54);
            this.acViewBtn.TabIndex = 29;
            this.acViewBtn.Text = "Avail Cap View";
            this.acViewBtn.UseVisualStyleBackColor = false;
            this.acViewBtn.Click += new System.EventHandler(this.acViewBtn_Click);
            // 
            // rpViewBtn
            // 
            this.rpViewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rpViewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rpViewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rpViewBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.rpViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rpViewBtn.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold);
            this.rpViewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rpViewBtn.Image = ((System.Drawing.Image)(resources.GetObject("rpViewBtn.Image")));
            this.rpViewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rpViewBtn.Location = new System.Drawing.Point(3, 319);
            this.rpViewBtn.Name = "rpViewBtn";
            this.rpViewBtn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.rpViewBtn.Size = new System.Drawing.Size(250, 54);
            this.rpViewBtn.TabIndex = 30;
            this.rpViewBtn.Text = "RP View";
            this.rpViewBtn.UseVisualStyleBackColor = false;
            this.rpViewBtn.Click += new System.EventHandler(this.rpViewBtn_Click);
            // 
            // trsViewBtn
            // 
            this.trsViewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.trsViewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.trsViewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trsViewBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.trsViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.trsViewBtn.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold);
            this.trsViewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.trsViewBtn.Image = ((System.Drawing.Image)(resources.GetObject("trsViewBtn.Image")));
            this.trsViewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trsViewBtn.Location = new System.Drawing.Point(3, 379);
            this.trsViewBtn.Name = "trsViewBtn";
            this.trsViewBtn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.trsViewBtn.Size = new System.Drawing.Size(250, 54);
            this.trsViewBtn.TabIndex = 31;
            this.trsViewBtn.Text = "TRS View";
            this.trsViewBtn.UseVisualStyleBackColor = false;
            this.trsViewBtn.Click += new System.EventHandler(this.trsViewBtn_Click_1);
            // 
            // headCountBtn
            // 
            this.headCountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.headCountBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.headCountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.headCountBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.headCountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.headCountBtn.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold);
            this.headCountBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.headCountBtn.Image = ((System.Drawing.Image)(resources.GetObject("headCountBtn.Image")));
            this.headCountBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.headCountBtn.Location = new System.Drawing.Point(3, 439);
            this.headCountBtn.Name = "headCountBtn";
            this.headCountBtn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.headCountBtn.Size = new System.Drawing.Size(250, 54);
            this.headCountBtn.TabIndex = 32;
            this.headCountBtn.Text = "Headcount";
            this.headCountBtn.UseVisualStyleBackColor = false;
            this.headCountBtn.Click += new System.EventHandler(this.headCountBtn_Click);
            // 
            // gocMasterBtn
            // 
            this.gocMasterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gocMasterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gocMasterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gocMasterBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.gocMasterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gocMasterBtn.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold);
            this.gocMasterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gocMasterBtn.Image = ((System.Drawing.Image)(resources.GetObject("gocMasterBtn.Image")));
            this.gocMasterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gocMasterBtn.Location = new System.Drawing.Point(3, 499);
            this.gocMasterBtn.Name = "gocMasterBtn";
            this.gocMasterBtn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.gocMasterBtn.Size = new System.Drawing.Size(250, 51);
            this.gocMasterBtn.TabIndex = 33;
            this.gocMasterBtn.Text = "GOC Master";
            this.gocMasterBtn.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold);
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.Location = new System.Drawing.Point(3, 556);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(250, 54);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // headCountUserControl11
            // 
            this.headCountUserControl11.BackColor = System.Drawing.Color.White;
            this.headCountUserControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headCountUserControl11.Location = new System.Drawing.Point(257, 0);
            this.headCountUserControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.headCountUserControl11.Name = "headCountUserControl11";
            this.headCountUserControl11.Size = new System.Drawing.Size(1187, 652);
            this.headCountUserControl11.TabIndex = 33;
            // 
            // trsView1
            // 
            this.trsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trsView1.ForeColor = System.Drawing.Color.Navy;
            this.trsView1.Location = new System.Drawing.Point(257, 0);
            this.trsView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trsView1.Name = "trsView1";
            this.trsView1.Size = new System.Drawing.Size(1187, 652);
            this.trsView1.TabIndex = 32;
            // 
            // avaiCapView1
            // 
            this.avaiCapView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avaiCapView1.Location = new System.Drawing.Point(257, 0);
            this.avaiCapView1.Name = "avaiCapView1";
            this.avaiCapView1.Size = new System.Drawing.Size(1187, 652);
            this.avaiCapView1.TabIndex = 31;
            // 
            // homeView11
            // 
            this.homeView11.BackColor = System.Drawing.Color.White;
            this.homeView11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeView11.Location = new System.Drawing.Point(257, 0);
            this.homeView11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homeView11.Name = "homeView11";
            this.homeView11.Size = new System.Drawing.Size(1187, 652);
            this.homeView11.TabIndex = 30;
            // 
            // rP_View2
            // 
            this.rP_View2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rP_View2.Location = new System.Drawing.Point(257, 0);
            this.rP_View2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rP_View2.Name = "rP_View2";
            this.rP_View2.Size = new System.Drawing.Size(1187, 652);
            this.rP_View2.TabIndex = 26;
            // 
            // allocation_Master1
            // 
            this.allocation_Master1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allocation_Master1.Location = new System.Drawing.Point(257, 0);
            this.allocation_Master1.Name = "allocation_Master1";
            this.allocation_Master1.Size = new System.Drawing.Size(1187, 652);
            this.allocation_Master1.TabIndex = 34;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(1444, 778);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.slidebar.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuIconButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer slidebarTimer;
        private Panel panel3;
        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Panel panel6;
        private Panel mainPanel;
        private FlowLayoutPanel slidebar;
        private Button exitBtn;
        private Panel panelMenu;
        private Label label1;
        private PictureBox menuIconButton;
        private Button resourceMasterBtn;
        private Button projectMasterBtn;
        private Button allocationMasterBtn;
        private Button acViewBtn;
        private Button rpViewBtn;
        private Button trsViewBtn;
        private Button headCountBtn;
        private Panel panel8;
        private PictureBox pictureBox2;
        private Label label2;
        private RP_View rP_View1;
       
        private RP_View rP_View2;
        
        private homeView1 homeView11;
        private avaiCapView avaiCapView1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private TRSView trsView1;
        private headCountUserControl1 headCountUserControl11;
        private Button gocMasterBtn;
        private BCPT.Allocation_Master allocation_Master1;
    }
}