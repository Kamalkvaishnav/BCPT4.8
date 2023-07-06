using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
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
    public partial class NewForm_modify : Form
    {

        static string connection = "server=localhost;uid=root;pwd=sql@password;database=project";

        MySqlConnection conn = new MySqlConnection(connection);
    

        private string ptsid;
        
        
        public NewForm_modify(string ptsid)
        {
            InitializeComponent();
            

            this.ptsid = ptsid;
            string query = "Select * from p_master where PTSID = @ptsid";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("ptsid", ptsid);
                DataTable table = new DataTable();

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }

                if (table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];

                    PTSID.Text = row["PTSID"].ToString();
                    Description.Text = row["Description"].ToString();
                    projecttype.Text = row["project_type"].ToString();
                    progId.Text = row["program_id"].ToString();
                    PM.Text = row["project_manager"].ToString();
                    piac.Text = row["piac_category"].ToString();
                    date1.Text = row["target_release_date"].ToString();
                    date2.Text = row["project_end_date"].ToString();
                    country_name.Text = row["country"].ToString();
                    product_name.Text = row["product"].ToString();
                    product_status.Text = row["status"].ToString();
                    SecoreL0.Text = row["secore_l0"].ToString();
                    NetL0.Text = row["dotnet_l0"].ToString();
                    SecoreL1.Text = row["secore_l1"].ToString();
                    NetL1.Text = row["dotnet_l1"].ToString();
                }
            }           
        }


       
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NewForm_modify_Load(object sender, EventArgs e)
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
            DateTime dateTime = DateTime.Now;

            string modified_time = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            string modified_by = "nidhi";

            string sqlinsert = "UPDATE p_master SET description = @Description, project_type = @p_type, program_id=@program_id, project_manager=@project_manager, piac_category=@piac, target_release_date=@date1, project_end_date=@date2, country=@country, product=@product, status=@status, secore_l0=@secoreL0, dotnet_l0=@dotnetL0, secore_l1=@secoreL1, dotnet_l1=@dotnetL1, modified_by=@name, modified_datetime=@time WHERE ptsid = @PTSId";

            
            conn.Open();

            MySqlCommand command = new MySqlCommand(sqlinsert, conn);

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
            command.Parameters.AddWithValue("@time", modified_time);
            command.Parameters.AddWithValue("@name", modified_by);


            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("data updated");
                this.Close();   
            }
            else
            {
                MessageBox.Show("data not updated");

            }

            
            conn.Close();
           // dataGridView1.Refresh();
            //this.Close();
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
    }
}
