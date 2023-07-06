using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ConsolFromApp
{
    public partial class RP_View : UserControl
    {

        public RP_View()
        {
            InitializeComponent();

        }

        


        private void RP_View_Load(object sender, EventArgs e)
        {

            rpViewDataGrid.DataSource = GetRPViewData();
            rpViewDataGrid.Columns[0].HeaderText = "Resource Manager";
            rpViewDataGrid.Columns[1].HeaderText = "SOEID";
            rpViewDataGrid.Columns[2].HeaderText = "Resource Name";
            rpViewDataGrid.Columns[3].HeaderText = "GOC";
            rpViewDataGrid.Columns[4].HeaderText = "Location";
            rpViewDataGrid.Columns[5].HeaderText = "PTSID";
            rpViewDataGrid.Columns[6].HeaderText = "Project Manager";
            rpViewDataGrid.Columns[7].HeaderText = "Project End Date";
            rpViewDataGrid.Columns[8].HeaderText = "Project Name";

            PopulateComboBoxes();




        }

        //This is a function to get the data from dataset and inserting it into the datagridview 
        private DataTable GetRPViewData()
        {
            string connstring = "server=localhost;uid=root;pwd=Kamal@21960;database=learnings";
            MySqlConnection conn = new MySqlConnection(connstring);
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();
                string sql = "SELECT rm.resource_manager_name, rm.SOEID, rm.resource_name, rm.goc, rm.location, pm.PTSID, pm.project_manager, pm.project_end_date,pm.description AS project_name\r\nFROM resource_master rm\r\nJOIN allocation_master am ON rm.SOEID = am.SOEID\r\nJOIN project_master pm ON am.PTSID = pm.PTSID\r\nORDER BY rm.resource_manager_name;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {    
                    dataTable.Load(reader);                  
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        private void PopulateComboBoxes()
        {
            DataTable dataTable = GetRPViewData();

            // Populate ComboBox1
            foreach (DataRow row in dataTable.Rows)
            {
                string value = row[0].ToString(); // Assuming the first column in the DataTable
                rmCb.Items.Add(value);
            }

            // Populate ComboBox2
            foreach (DataRow row in dataTable.Rows)
            {
                string value = row[1].ToString(); // Assuming the second column in the DataTable
                soeidCb.Items.Add(value);
            }

            // Populate ComboBox3
            foreach (DataRow row in dataTable.Rows)
            {
                string value = row[2].ToString(); // Assuming the third column in the DataTable
                rnCb.Items.Add(value);
            }

            // Populate ComboBox4
            foreach (DataRow row in dataTable.Rows)
            {
                string value = row[3].ToString(); // Assuming the fourth column in the DataTable
                gocCb.Items.Add(value);
            }
        }

        private void FilterDataGridView()
        {
            string columnName1 = "resource_manager_name"; // Replace with the actual column name
            string columnName2 = "resource_name"; // Replace with the actual column name
            string columnName3 = "SOEID"; // Replace with the actual column name
            string columnName4 = "goc"; // Replace with the actual column name

            string filterQuery = "";

            // Check if ComboBox1 has a selected value
            if (rmCb.SelectedIndex != -1)
            {
                string selectedValue1 = rmCb.SelectedItem.ToString();
                filterQuery += $"{columnName1} = '{selectedValue1}'";
            }

            // Check if ComboBox2 has a selected value
            if (rnCb.SelectedIndex != -1)
            {
                string selectedValue2 = rnCb.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(filterQuery))
                    filterQuery += " AND ";
                filterQuery += $"{columnName2} = '{selectedValue2}'";
            }

            // Check if ComboBox3 has a selected value
            if (soeidCb.SelectedIndex != -1)
            {
                string selectedValue3 = soeidCb.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(filterQuery))
                    filterQuery += " AND ";
                filterQuery += $"{columnName3} = '{selectedValue3}'";
            }

            // Check if ComboBox4 has a selected value
            if (gocCb.SelectedIndex != -1)
            {
                string selectedValue4 = gocCb.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(filterQuery))
                    filterQuery += " AND ";
                filterQuery += $"{columnName4} = '{selectedValue4}'";
            }

            // Apply the filter to the DataGridView
            (rpViewDataGrid.DataSource as DataTable).DefaultView.RowFilter = filterQuery;
        }



        private DataTable RscNameSearch()
        {
            string connstring = "server=localhost;uid=root;pwd=Kamal@21960;database=learnings";
            MySqlConnection conn = new MySqlConnection(connstring);
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();
                string sql;
               
                
                sql = "SELECT rm.resource_manager_name, rm.SOEID, rm.resource_name, rm.goc, rm.location, pm.PTSID, pm.project_manager, pm.project_end_date,pm.description AS project_name\r\nFROM resource_master rm\r\nJOIN allocation_master am ON rm.SOEID = am.SOEID\r\nJOIN project_master pm ON am.PTSID = pm.PTSID\r\nORDER BY rm.resource_manager_name;";
                

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    dataTable.Load(reader);
                    
                }

                ;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            FilterDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rmCb.SelectedIndex = -1 ;
            rnCb.SelectedIndex = -1;
            soeidCb.SelectedIndex = -1;
            gocCb.SelectedIndex = -1;

            (rpViewDataGrid.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
