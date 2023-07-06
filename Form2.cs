using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();

            // Attach the CloseUp event handler to date1
            date1.CloseUp += date1_CloseUp;
        }

        private void date1_CloseUp(object sender, EventArgs e)
        {
            // Retrieve the selected value of date1
            DateTime selectedDate = date1.Value;

            // Set the minimum date or disable dates in date2 based on selectedDate
            date2.MinDate = selectedDate.AddDays(1);
        }



        // string connstring = "server=localhost;uid=root;pwd=sql@password;database=project";
        MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=sql@password;database=project");
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            // Retrieve form data
            string PtsID = PTSID.Text;
            string description = Description.Text;
            string p_type = projecttype.SelectedItem.ToString();
            string program_id = progId.SelectedItem.ToString();
            string project_manager = PM.SelectedItem.ToString();
            string piac_category = piac.SelectedItem.ToString();
            DateTime target_release_date = date1.Value;
            DateTime project_end_date = date2.Value;
            string country = country_name.SelectedItem.ToString();
            string product = product_name.SelectedItem.ToString();
            string status = product_status.SelectedItem.ToString();
            int secore_l0 = Convert.ToInt32(SecoreL0.Text);
            int dotnet_l0 = Convert.ToInt32(NetL0.Text);
            int secore_l1 = Convert.ToInt32(SecoreL1.Text);
            int dotnet_l1 = Convert.ToInt32(NetL1.Text);
            //DateTime modified_datetime = nameTextBox.Text;
           

            string sqlInsert = "INSERT INTO P_Master VALUES (@PTSId, @Description, @p_type, @program_id, @project_manager, @piac, @date1, @date2, @country, @product, @status, @secoreL0, @dotnetL0, @secoreL1, @dotnetL1,'nidhi', CURRENT_TIMESTAMP)";

            connection.Open();

            MySqlCommand command = new MySqlCommand(sqlInsert, connection);

            command.Parameters.AddWithValue("@PTSId", PtsID);
            command.Parameters.AddWithValue("@Description", description);
            command.Parameters.AddWithValue("@p_type", p_type);
            command.Parameters.AddWithValue("@program_id", program_id);
            command.Parameters.AddWithValue("@project_manager", project_manager);
            command.Parameters.AddWithValue("@piac", piac_category);
            command.Parameters.AddWithValue("@date1", target_release_date);
            command.Parameters.AddWithValue("@date2", project_end_date);
            command.Parameters.AddWithValue("@country", country);
            command.Parameters.AddWithValue("@product", product);
            command.Parameters.AddWithValue("@status", status);
            command.Parameters.AddWithValue("@secoreL0", secore_l0);
            command.Parameters.AddWithValue("@dotnetL0", dotnet_l0);
            command.Parameters.AddWithValue("@secoreL1", secore_l1);
            command.Parameters.AddWithValue("@dotnetL1", dotnet_l1);

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("data inserted");
            }
            else
            {
                MessageBox.Show("data not inserted");

            }

            connection.Close();
            this.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void NetL0_TextChanged(object sender, EventArgs e)
        {

        }

        private void PTSID_TextChanged(object sender, EventArgs e)
        {

        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NetL1_TextChanged(object sender, EventArgs e)
        {

        }

        private void date2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
