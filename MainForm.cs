using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System;
using BCPT;

namespace ConsolFromApp
{
    public partial class MainForm : Form
    {
        bool slidebarExpand;
        public static MainForm instance;
        public Label user;
        public MainForm()
        {
            InitializeComponent();
            instance = this;
            user = new Label();

        }


        public void RefreshAllocationMaster()
        {
            allocation_Master1.LoadData(); // Assuming allocationMaster is the instance of the Allocation_Master user control
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            homeView1.instance.lb1.Text = user.Text;
            //gocMaster.instance.loginId = user.Text;
            homeView11.Visible = true;
            allocation_Master1.Visible = false;
            rP_View2.Visible = false;
            avaiCapView1.Visible = false;
            trsView1.Visible = false;
            headCountUserControl11.Visible = false;
        }

        private void slidebarTimer_Tick_1(object sender, EventArgs e)
        {
            if (slidebarExpand)
            {
                slidebar.Width -= 10;
                if (slidebar.Width <= slidebar.MinimumSize.Width)
                {
                    slidebar.Width = slidebar.MinimumSize.Width;
                    slidebarExpand = false;
                    slidebarTimer.Stop();
                }
            }
            else
            {
                slidebar.Width += 10;
                if (slidebar.Width >= slidebar.MaximumSize.Width)
                {
                    slidebar.Width = slidebar.MaximumSize.Width;
                    slidebarExpand = true;
                    slidebarTimer.Stop();
                }
            }
        }


       

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you really want to exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }


        

       

        private void menuIconButton_Click_1(object sender, EventArgs e)
        {
            slidebarTimer.Start();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            avaiCapView1.Visible = false;
            homeView11.Visible = true;
            rP_View2.Visible = false;
            headCountUserControl11.Visible = false;
            trsView1.Visible = false;
            allocation_Master1.Visible = false;


        }

        private void rpViewBtn_Click(object sender, EventArgs e)
        {
            rP_View2.Visible = true;
            avaiCapView1.Visible = false; 
            headCountUserControl11.Visible = false;
            homeView11.Visible = false;
            trsView1.Visible = false;
            allocation_Master1.Visible = false;
        }

        private void trsViewBtn_Click_1(object sender, EventArgs e)
        {
            avaiCapView1.Visible = false;
            headCountUserControl11.Visible = false;
            homeView11.Visible = false;
            rP_View2.Visible = false;
            trsView1.Visible = true;
            allocation_Master1.Visible = false;
        }

       

        private void label2_Click_1(object sender, EventArgs e)
        {

            DialogResult res;
            res = MessageBox.Show("Do you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void acViewBtn_Click(object sender, EventArgs e)
        {
            avaiCapView1.Visible = true;
            headCountUserControl11.Visible = false;
            homeView11.Visible = false;
            rP_View2.Visible = false;
            trsView1.Visible = false;
            allocation_Master1.Visible = false;
        }

        private void headCountBtn_Click(object sender, EventArgs e)
        {
            headCountUserControl11.Visible = true;
            avaiCapView1.Visible = false;
            homeView11.Visible = false;
            rP_View2.Visible = false;
            allocation_Master1.Visible = false;
            trsView1.Visible = false;

        }

        private void allocationMasterBtn_Click(object sender, EventArgs e)
        {
            headCountUserControl11.Visible = false;
            avaiCapView1.Visible = false;
            homeView11.Visible = false;
            rP_View2.Visible = false;
            allocation_Master1.Visible = true;
            trsView1.Visible = false;
        }
    }
}