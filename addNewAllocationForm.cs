using ConsolFromApp;
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

namespace BCPT
{
    public partial class addNewAllocationForm : Form
    {
        private Allocation_Master allocationMaster;
        public addNewAllocationForm(Allocation_Master allocationMaster)
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private DataTable GetAMViewData()
        {
            string connstring = "server=localhost;uid=root;pwd=Kamal@21960;database=learnings";
            MySqlConnection conn = new MySqlConnection(connstring);
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();
                string sql = "SELECT \r\n    rm.SOEID, \r\n    rm.resource_name AS Name, \r\n    pm.PTSID,\r\n    pm.description AS project_name,\r\n    pm.project_manager, \r\n    pm.target_release_date AS ReleaseDate,\r\n    rm.goc AS Goc, \r\n    rm.location AS Location, \r\n    rm.feature_team AS Feature_Team,\r\n    am.Month,\r\n    am.Year,\r\n am.allocation \r\n FROM \r\n    resource_master rm\r\n    JOIN allocation_master am ON rm.SOEID = am.SOEID\r\n    JOIN project_master pm ON am.PTSID = pm.PTSID\r\nORDER BY \r\n    rm.resource_manager_name;\r\n";
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

        private DataTable GetProjectData()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string connstring = "server=localhost;uid=root;pwd=Kamal@21960;database=learnings";
                MySqlConnection conn = new MySqlConnection(connstring);

                conn.Open();

                string sql = "SELECT * FROM project_master";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        private DataTable GetResourceData()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string connstring = "server=localhost;uid=root;pwd=Kamal@21960;database=learnings";
                MySqlConnection conn = new MySqlConnection(connstring);

                conn.Open();

                string sql = "SELECT * FROM resource_master";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }


        private void PopulateComboBoxes()
        {
            DataTable projectDataTable = GetProjectData();
            DataTable resourceDataTable = GetResourceData();

            // Populate PTSID ComboBox
            foreach (DataRow row in projectDataTable.Rows)
            {
                string ptsidValue = row["PTSID"].ToString(); // Assuming the PTSID column name in the DataTable
                ptsidCb.Items.Add(ptsidValue);
            }

            // Populate SOEID ComboBox
            foreach (DataRow row in resourceDataTable.Rows)
            {
                string soeidValue = row["SOEID"].ToString(); // Assuming the SOEID column name in the DataTable
                soeidCb.Items.Add(soeidValue);
            }


            // Populate monthCb with numbers 1 to 12
            for (int month = 1; month <= 12; month++)
            {
                monthCb.Items.Add(month);
            }

            // Populate yearCb with selectable years
            var years = Enumerable.Range(DateTime.Now.Year - 10, 20); // Adjust the range of years as per your requirement
            foreach (int year in years)
            {
                yearCb.Items.Add(year);
            }




        }

        private void addNewAllocationForm_Load(object sender, EventArgs e)
        {
            PopulateComboBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the PTSID ComboBox is not selected or has no text
            if (string.IsNullOrEmpty(ptsidCb.Text))
            {
                MessageBox.Show("Please select or enter a valid PTSID.");
                return; // Exit the method
            }

            // Check if the SOEID ComboBox is not selected or has no text
            if (string.IsNullOrEmpty(soeidCb.Text))
            {
                MessageBox.Show("Please select or enter a valid SOEID.");
                return; // Exit the method
            }

            // Retrieve the selected PTSID and SOEID from the ComboBoxes
            string selectedPTSID = ptsidCb.Text;
            string selectedSOEID = soeidCb.Text;

            // Check if the selected PTSID exists in the available options
            bool isValidPTSID = ptsidCb.Items.Contains(selectedPTSID);
            if (!isValidPTSID)
            {
                MessageBox.Show("Selected PTSID is not valid.");
                return; // Exit the method
            }

            // Check if the selected SOEID exists in the available options
            bool isValidSOEID = soeidCb.Items.Contains(selectedSOEID);
            if (!isValidSOEID)
            {
                MessageBox.Show("Selected SOEID is not valid.");
                return; // Exit the method
            }

            // Retrieve the data from the resource_master table based on the selected SOEID
            DataTable resourceDataTable = GetResourceData();
            DataRow[] resourceRows = resourceDataTable.Select($"SOEID = '{selectedSOEID}'");

            // Check if any matching row is found
            if (resourceRows.Length > 0)
            {
                // Retrieve the first matching row
                DataRow resourceRow = resourceRows[0];

                // Populate the corresponding fields with the retrieved data
                nameTextBox.Text = resourceRow[1].ToString();
                gocTextBox.Text = resourceRow[3].ToString();
                locationTextBox.Text = resourceRow[6].ToString();
                featureTeamTextBox.Text = resourceRow[7].ToString();
            }

            // Retrieve the data from the project_master table based on the selected PTSID
            DataTable projectDataTable = GetProjectData();
            DataRow[] projectRows = projectDataTable.Select($"PTSID = '{selectedPTSID}'");

            // Check if any matching row is found
            if (projectRows.Length > 0)
            {
                // Retrieve the first matching row
                DataRow projectRow = projectRows[0];

                // Populate the corresponding fields with the retrieved data
                projectNameTextBox.Text = projectRow[1].ToString();
                projectManagerTextBox.Text = projectRow[4].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
            // Retrieve the selected PTSID and SOEID from the ComboBoxes
            string selectedPTSID = ptsidCb.Text;
                string selectedSOEID = soeidCb.Text;

                // Retrieve the selected month and year from the ComboBoxes
                int selectedMonth = Convert.ToInt32(monthCb.SelectedItem);
                int selectedYear = Convert.ToInt32(yearCb.SelectedItem);
                string modified_by = mainForm.user.Text;
                DateTime modified_datetime = DateTime.Now;


                // Retrieve the allocation value
                decimal allocation = decimal.Parse(allocationTextBox.Text);

                // Validate the allocation value
                if (allocation >= 1)
                {
                    MessageBox.Show("Allocation must be less than or equal to 1.");
                    return; // Exit the method
                }

                // Truncate allocation value to two decimal places
                allocation = Math.Truncate(allocation * 100) / 100;

                // Insert the data into the Allocation master table
                InsertAllocationData(selectedPTSID, selectedSOEID, selectedMonth, selectedYear, allocation, modified_by, modified_datetime);

                // Show success message
                MessageBox.Show("Allocation added successfully.");

                // Hide the form
                this.Hide();

            // Refresh the DataGridView in the allocation master screen
            
            mainForm?.RefreshAllocationMaster();


        }

        private void InsertAllocationData(string ptsid, string soeid, int month, int year, decimal allocation, string modified_by, DateTime modified_datetime)
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=Kamal@21960;database=learnings";
                using (MySqlConnection conn = new MySqlConnection(connstring))
                {
                    conn.Open();

                    string sql = "INSERT INTO allocation_master (PTSID, SOEID, Month, Year, allocation, modified_by, modified_datetime) VALUES (@PTSID, @SOEID, @Month, @Year, @Allocation, @ModifiedBy, @ModifiedDateTime)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@PTSID", ptsid);
                    cmd.Parameters.AddWithValue("@SOEID", soeid);
                    cmd.Parameters.AddWithValue("@Month", month);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@Allocation", allocation);
                    cmd.Parameters.AddWithValue("@ModifiedBy", modified_by);
                    cmd.Parameters.AddWithValue("@ModifiedDateTime", modified_datetime);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Data inserted successfully
                    }
                    else
                    {
                        // Failed to insert data
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting the data: " + ex.Message);
            }
        }



    }
}
