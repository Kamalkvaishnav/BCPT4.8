using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ConsolFromApp
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();

        }




        private void Login_Click(object sender, EventArgs e)
        {
            string username = userNameBox.Text;
            string password = pwdBox.Text;

            string connstring = "server=localhost;uid=root;pwd=Kamal@21960;database=learnings";
            MySqlConnection conn = new MySqlConnection(connstring);
            try
            {


                conn.Open();
                string sql = "Select * from login_new where username = '" + userNameBox.Text + "' AND password = '" + pwdBox.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                if (dt.Rows.Count > 0)
                {
                    username = userNameBox.Text;
                    password = pwdBox.Text;

                    MainForm form2 = new MainForm();
                    form2.user.Text = Char.ToUpper(username[0]) + username.Substring(1);
                    form2.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid login details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    userNameBox.Clear();
                    pwdBox.Clear();
                    userNameBox.Focus();
                    this.Show();
                }

            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            userNameBox.Clear();
            pwdBox.Clear();
            userNameBox.Focus();
        }

        private void Exit_Click(object sender, EventArgs e)
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




        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

       
    }
}
