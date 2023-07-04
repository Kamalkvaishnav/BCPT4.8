using MySql.Data.MySqlClient;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConsolFromApp
{
    public partial class avaiCapView : UserControl


    {


        MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=Kamal@21960;database=learnings");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;




        public avaiCapView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /* public void searchData(string res_name, string appln, string ft_team)
         {
             string query = "SELECT * FROM acv WHERE CONCAT(`name`, `appln`, `pt`) LIKE '%" + res_name + "%' OR CONCAT(`name`, `appln`, `pt`,) LIKE '%" + appln + "%' OR CONCAT(`name`, `appln`, `pt`) LIKE '%" + ft_team + "%'";
             command = new MySqlCommand(query, connection);
             adapter = new MySqlDataAdapter(command);
             table = new DataTable();
             adapter.Fill(table);
             dataGridView1.DataSource = table;
         }

        private void button1_Click(object sender, EventArgs e)
        {
            string res_name = comboBox1.Text.ToString();
            string appln = comboBox2.Text.ToString();
            string ft_team = comboBox3.Text.ToString();

            // searchData(res_name, appln, ft_team);

            //searchData(valueToSearch);
        }
        */
        public void filterName(string res_name)
        {
            string query = "SELECT * FROM acv WHERE CONCAT(`name`) LIKE '%" + res_name + "%' ";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }
        private void button2_Click(object sender, EventArgs e)
        {


        }

        public void filterAppln(string appln)
        {
            string query = "SELECT * FROM acv WHERE CONCAT(`appln`) LIKE '%" + appln + "%' ";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public void filterFt_team(string ft_team)
        {
            string query = "SELECT * FROM acv WHERE CONCAT(`ft_team`) LIKE '%" + ft_team + "%' ";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;


        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        public void filterPt(string pt)
        {
            string query = "SELECT * FROM acv WHERE CONCAT(`pt`) LIKE '%" + pt + "%' ";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pt = comboBox3.Text.ToString();
            filterPt(pt);
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ft_team = comboBox4.Text.ToString();
            filterFt_team(ft_team);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string res_name = comboBox1.Text.ToString();
            filterName(res_name);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string appln = comboBox2.Text.ToString();
            filterAppln(appln);
        }

        //clear filters
        private void button1_Click_1(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
            comboBox4.Text = string.Empty;
            string query = "SELECT * FROM acv where name='1'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            DataTable tb = new DataTable();
            dataGridView1.DataSource = tb;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save Excel File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                ExportToExcel(dataGridView1, excelFile);
                MessageBox.Show("Excel file saved successfully!");
            }
        }

        private void ExportToExcel(DataGridView dataGridView, FileInfo excelFile)
        {
            using (ExcelPackage package = new ExcelPackage(excelFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");
                worksheet.Cells["A1"].LoadFromDataTable(table, true);

                package.Save();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM acv";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
