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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BCPT
{
    public partial class Allocation_Master : UserControl
    {
        public Allocation_Master()
        {
            InitializeComponent();
        }

        private void amViewDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private DataTable GetAMViewData()
        {
            string connstring = "server=localhost;uid=root;pwd=Kamal@21960;database=learnings";
            MySqlConnection conn = new MySqlConnection(connstring);
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();
                string sql = "SELECT \r\n    rm.SOEID, \r\n    rm.resource_name AS Name, \r\n    pm.PTSID,\r\n    pm.description AS project_name,\r\n    pm.project_manager, \r\n    pm.target_release_date AS ReleaseDate,\r\n    rm.goc AS Goc, \r\n    rm.location AS Location, \r\n    rm.feature_team AS Feature_Team,\r\n    am.Month,\r\n    am.Year,\r\n am.allocation, \r\n am.IsArchived \r\n  FROM \r\n    resource_master rm\r\n    JOIN allocation_master am ON rm.SOEID = am.SOEID\r\n    JOIN project_master pm ON am.PTSID = pm.PTSID\r\nORDER BY \r\n    rm.resource_manager_name;\r\n";
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
            DataTable dataTable = GetAMViewData();

            // Populate ComboBox1 with unique values
            foreach (DataRow row in dataTable.Rows)
            {
                string value = row[0].ToString(); // Assuming the first column in the DataTable
                if (!soeidCb.Items.Contains(value))
                {
                    soeidCb.Items.Add(value);
                }
            }

            // Populate ComboBox2 with unique values
            foreach (DataRow row in dataTable.Rows)
            {
                string value = row[1].ToString(); // Assuming the second column in the DataTable
                if (!nameCb.Items.Contains(value))
                {
                    nameCb.Items.Add(value);
                }
            }

            // Populate ComboBox3 with unique values
            foreach (DataRow row in dataTable.Rows)
            {
                string value = row[2].ToString(); // Assuming the third column in the DataTable
                if (!ptsidCb.Items.Contains(value))
                {
                    ptsidCb.Items.Add(value);
                }
            }

            // Populate ComboBox4 with unique values
            foreach (DataRow row in dataTable.Rows)
            {
                string value = row[3].ToString(); // Assuming the fourth column in the DataTable
                if (!pnCb.Items.Contains(value))
                {
                    pnCb.Items.Add(value);
                }
            }

            // Populate ComboBox5 with unique values
            foreach (DataRow row in dataTable.Rows)
            {
                string value = row[8].ToString(); // Assuming the ninth column in the DataTable
                if (!ftCb.Items.Contains(value))
                {
                    ftCb.Items.Add(value);
                }
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

        private void FilterDataGridView()
        {
            string columnName1 = "Name";
            string columnName2 = "PTSID";
            string columnName3 = "SOEID";
            string columnName4 = "project_name";
            string columnName5 = "Feature_Team";
            string columnName6 = "IsArchived";

            string filterQuery = "";

            // Check if ComboBox1 has a selected value
            if (nameCb.SelectedIndex != -1)
            {
                string selectedValue1 = nameCb.SelectedItem.ToString();
                filterQuery += $"{columnName1} = '{selectedValue1}'";
            }

            // Check if ComboBox2 has a selected value
            if (ptsidCb.SelectedIndex != -1)
            {
                string selectedValue2 = ptsidCb.SelectedItem.ToString();
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
            if (pnCb.SelectedIndex != -1)
            {
                string selectedValue4 = pnCb.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(filterQuery))
                    filterQuery += " AND ";
                filterQuery += $"{columnName4} = '{selectedValue4}'";
            }

            // Check if ComboBox4 has a selected value
            if (ftCb.SelectedIndex != -1)
            {
                string selectedValue4 = ftCb.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(filterQuery))
                    filterQuery += " AND ";
                filterQuery += $"{columnName5} = '{selectedValue4}'";
            }

            // Check if ComboBox6 has a selected value
            if (isArchivedCb.SelectedIndex != -1)
            {
                bool isArchived = isArchivedCb.SelectedItem.ToString() == "True";
                if (!string.IsNullOrEmpty(filterQuery))
                    filterQuery += " AND ";
                filterQuery += $"{columnName6} = {Convert.ToInt32(isArchived)}";
            }

        // Apply the filter to the DataGridView
        (amViewDataGrid.DataSource as DataTable).DefaultView.RowFilter = filterQuery;
            }


        public void LoadData()
        {
            // Retrieve the data for the DataGridView
            DataTable dataTable = GetAMViewData();

            // Set the DataTable as the data source for the DataGridView
            amViewDataGrid.DataSource = dataTable;
        }


        private void Allocation_Master_Load(object sender, EventArgs e)
        {
            amViewDataGrid.DataSource = GetAMViewData();
            PopulateComboBoxes();
            // Assuming the column index of the "Month" column is 10 (0-based index)
            int monthColumnIndex = 10;

            // Define a dictionary to map month numbers to month names
            Dictionary<int, string> monthNames = new Dictionary<int, string>()
{
            { 1, "January" },
            { 2, "February" },
            { 3, "March" },
            { 4, "April" },
            { 5, "May" },
            { 6, "June" },
            { 7, "July" },
            { 8, "August" },
            { 9, "September" },
            { 10, "October" },
            { 11, "November" },
            { 12, "December" }
        };

            // Handle the CellFormatting event of the DataGridView
            amViewDataGrid.CellFormatting += (datagridSender, cellFormattingEventArgs) =>
            {
                // Check if the current cell is in the "Month" column
                if (cellFormattingEventArgs.ColumnIndex == monthColumnIndex && cellFormattingEventArgs.RowIndex >= 0)
                {
                    // Get the original value of the cell
                    string monthValue = cellFormattingEventArgs.Value?.ToString();

                    // Convert the month value to an integer
                    if (int.TryParse(monthValue, out int monthNumber))
                    {
                        // Check if the month number exists in the dictionary
                        if (monthNames.ContainsKey(monthNumber))
                        {
                            // Set the displayed value of the cell to the corresponding month name
                            cellFormattingEventArgs.Value = monthNames[monthNumber];
                            cellFormattingEventArgs.FormattingApplied = true;
                        }
                    }
                }
            };








        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            FilterDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameCb.SelectedIndex = -1;
            pnCb.SelectedIndex = -1;
            soeidCb.SelectedIndex = -1;
            ptsidCb.SelectedIndex = -1;
            ftCb.SelectedIndex = -1;

            (amViewDataGrid.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create a list to store the rows to be deleted
            List<DataGridViewRow> rowsToDelete = new List<DataGridViewRow>();

            // Iterate through the DataGridView rows
            foreach (DataGridViewRow row in amViewDataGrid.Rows)
            {
                // Retrieve the checkbox cell for each row
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;

                // Check if the checkbox in the current row is checked
                if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                {
                    // Add the row to the list of rows to be deleted
                    rowsToDelete.Add(row);
                }
            }

            // Check if there are rows selected for deletion
            if (rowsToDelete.Count > 0)
            {
                // Confirm the deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected rows?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Delete the rows from the DataGridView and the database
                    foreach (DataGridViewRow rowToDelete in rowsToDelete)
                    {
                        // Retrieve the PTSID and SOEID from the selected row
                        string ptsid = rowToDelete.Cells["PTSID"].Value.ToString();
                        string soeid = rowToDelete.Cells["SOEID"].Value.ToString();

                        // Delete the row from the database using PTSID and SOEID
                        DeleteRowFromDatabase(ptsid, soeid);

                        // Remove the row from the DataGridView
                        amViewDataGrid.Rows.Remove(rowToDelete);
                    }

                    // Refresh the DataGridView
                    amViewDataGrid.Refresh();
                }
            }
            else
            {
                MessageBox.Show("No rows selected for deletion.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteRowFromDatabase(string ptsid, string soeid)
        {
            string connstring = "server=localhost;uid=root;pwd=Kamal@21960;database=learnings";
            using (MySqlConnection conn = new MySqlConnection(connstring))
            {
                try
                {
                    conn.Open();

                    // Create the SQL delete query with parameters
                    string deleteQuery = "DELETE FROM allocation_master WHERE PTSID = @PTSID AND SOEID = @SOEID";

                    // Create the MySqlCommand object
                    using (MySqlCommand command = new MySqlCommand(deleteQuery, conn))
                    {
                        // Add the parameters and their values
                        command.Parameters.AddWithValue("@PTSID", ptsid);
                        command.Parameters.AddWithValue("@SOEID", soeid);

                        // Execute the delete query
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            addNewAllocationForm newAllocationForm = new addNewAllocationForm(this);
            newAllocationForm.Show();
            
        }

        private void ArchiveButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in amViewDataGrid.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;

                if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                {
                    // Set the value of "IsArchived" column to true
                    row.Cells["IsArchived"].Value = true;

                    // Get the values of PTSID and SOEID
                    string selectedPTSID = row.Cells["PTSID"].Value.ToString();
                    string selectedSOEID = row.Cells["SOEID"].Value.ToString();

                    // Save changes to the database
                    SaveChangesToDatabase(selectedPTSID, selectedSOEID);
                }
            }
        }

        // To save the archive and unarchive state in database
        private void SaveChangesToDatabase(string selectedPTSID, string selectedSOEID)
        {
            string connstring = "server=localhost;uid=root;pwd=Kamal@21960;database=learnings";
            MySqlConnection conn = new MySqlConnection(connstring);

            try
            {
                conn.Open();

                // Save changes to the database
                MySqlCommand cmd = new MySqlCommand("UPDATE allocation_master SET IsArchived = @IsArchived WHERE PTSID = @PTSID AND SOEID = @SOEID", conn);

                // Set the parameter values
                cmd.Parameters.AddWithValue("@IsArchived", true);
                cmd.Parameters.AddWithValue("@PTSID", selectedPTSID);
                cmd.Parameters.AddWithValue("@SOEID", selectedSOEID);

                // Execute the query
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }




       
        


    }
}
