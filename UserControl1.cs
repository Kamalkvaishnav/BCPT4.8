using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp2
{
    public partial class UserControl1 : UserControl
    {
        string selected_column;

        public UserControl1()
        {
            InitializeComponent();
        }
        static string connstring = "server=localhost;uid=root;pwd=sql@password;database=project";
        MySqlConnection connection = new MySqlConnection(connstring);
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        string ptsid_row;

        private DataTable GetProjectMasterData()
        {
            //string connstring = "server=localhost;uid=root;pwd=sql@password;database=project";
            MySqlConnection conn = new MySqlConnection(connstring);
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();
                string sql = " SELECT * FROM project.p_master";
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


        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            // Check if the new row is the add row
            if (e.RowIndex == dataGridView.Rows.Count - 1 && !dataGridView.Rows[e.RowIndex].IsNewRow)
            {
                // Set the checkbox value for the new row
                DataGridViewCheckBoxCell checkboxCell = (DataGridViewCheckBoxCell)dataGridView.Rows[e.RowIndex].Cells["CheckboxColumn"];
                checkboxCell.Value = false;
            }
        }



        private void UserControl1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetProjectMasterData();         

            // Set up the checkbox column
            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn
            {
                Name = "CheckboxColumn",
                HeaderText = "Select",
                DataPropertyName = "Select",
                Width = 50
            };
            dataGridView1.Columns.Insert(0, checkboxColumn);

            dataGridView1.RowsAdded += dataGridView1_RowsAdded;
            button4.Click += button4_Click;

            // Populate the combo box with project_type values
            string query = "SELECT DISTINCT project_type FROM p_master";
            command = new MySqlCommand(query, connection);

            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string projectType = reader.GetString(reader.GetOrdinal("project_type"));

                comboBox_p_type.Items.Add(projectType);
            }

            reader.Close();
            connection.Close();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WindowsFormsApp1.Form2 form2 = new WindowsFormsApp1.Form2();
            form2.Show();
        }

       
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Visible && e.RowIndex >= 0 && e.ColumnIndex == 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell is DataGridViewCheckBoxCell checkBoxCell && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                {
                    if (button6.Enabled)
                    {
                        // Show button7 when checkbox is selected and button6 is enabled
                        button7.Visible = true;
                    }
                    else
                    {
                        // Hide button7 when checkbox is selected and button6 is disabled
                        button7.Visible = false;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM p_master WHERE archive = 0";
            command = new MySqlCommand(query, connection);

            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string valueToSearch = textBox1.Text.ToString();
            searchData(valueToSearch);
        }

        public void searchData(string valueToSearch)
        {
            string query = "select * from p_master where description like '%" + valueToSearch + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button4_Click(object sender, EventArgs e)
        {


            // Create a list to store the primary keys of the deleted rows
            List<string> deletedRowIds = new List<string>();

            // Iterate over the selected rows in the DataGridView
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];

                // Check if the checkbox cell is selected
                DataGridViewCheckBoxCell checkboxCell = (DataGridViewCheckBoxCell)row.Cells["CheckboxColumn"]; // Replace "CheckboxColumn" with your actual checkbox column name
                if (Convert.ToBoolean(checkboxCell.Value))
                {


                    // Get the primary key or unique identifier of the deleted row
                    string rowId = Convert.ToString(row.Cells[1].Value); // Replace "PrimaryKeyColumn" with the actual column name of the primary key
                    MessageBox.Show("rowid   " + rowId.ToString());

                    deletedRowIds.Add(rowId);
                    dataGridView1.Rows.RemoveAt(i);

                }
            }

            // Delete the rows from the database using the list of deletedRowIds
            DeleteRowsFromDatabase(deletedRowIds);

            // Refresh the DataGridView to reflect the changes
            dataGridView1.Refresh();
        }

        private void DeleteRowsFromDatabase(List<string> deletedRowIds)
        {
            string connstring = "server=localhost;uid=root;pwd=sql@password;database=project";
            MySqlConnection conn = new MySqlConnection(connstring);

            try
            {
                conn.Open();

                foreach (string rowId in deletedRowIds)
                {
                    // Execute the DELETE query using the rowId
                    string deleteQuery = "DELETE FROM p_master WHERE PTSID = '" + rowId + "'"; // Replace YourTableName and PrimaryKeyColumn with your actual table and column names
                    MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);

                    cmd.ExecuteNonQuery();
                }
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

       
        private void button5_Click(object sender, EventArgs e)
        {
            using (connection = new MySqlConnection(connstring))
            {
                connection.Open();
                int totalRows = this.dataGridView1.RowCount;

                List<string> listOfPTSids = new List<string>();


                for (int i = 0; i < totalRows; i++)
                {

                    if (this.dataGridView1.Rows[i].Cells[0].Value != null && (bool)this.dataGridView1.Rows[i].Cells[0].Value == true)
                    {
                        listOfPTSids.Add((((System.Data.DataTable)this.dataGridView1.DataSource).Rows[i]["PTSID"]).ToString());

                    }

                }
                int j = listOfPTSids.Count;
                if (j > 1)
                {

                    MessageBox.Show("Choose only one resource to edit at one time.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else if (j == 0)
                {
                    MessageBox.Show("Select one row to edit");
                }
                else
                {

                    MessageBox.Show(listOfPTSids.Count().ToString());
                    string ptsid = listOfPTSids[0];

                    NewForm_modify form5 = new NewForm_modify(ptsid);

                    form5.FormClosed += Form5__FormClosed;


                    form5.Show();
                }


            }


        }

        public void Form5__FormClosed(object sender, FormClosedEventArgs e)
        {
            string query = "SELECT * FROM p_master";
            command = new MySqlCommand(query, connection);

            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Refresh();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            using (connection = new MySqlConnection(connstring))
            {
                connection.Open();
                int totalRows = this.dataGridView1.RowCount;

                List<string> listOfPtsids = new List<string>();

                for (int i = 0; i < totalRows; i++)
                {
                    if (this.dataGridView1.Rows[i].Cells[0].Value != null && (bool)this.dataGridView1.Rows[i].Cells[0].Value == true)
                    {
                        listOfPtsids.Add((((System.Data.DataTable)this.dataGridView1.DataSource).Rows[i]["PTSID"]).ToString());
                    }
                }

                int j = listOfPtsids.Count();
                for (int i = 0; i < j; i++)
                {
                    string ptsid = listOfPtsids[i];
                    string query = "UPDATE p_master SET archive = 1 WHERE PTSID = @ptsid";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ptsid", ptsid);

                        // Execute the update command
                        command.ExecuteNonQuery();
                    }
                }

                // Close the connection after all updates have been performed
                connection.Close();

                // Display the message box and retrieve the updated data
                if (listOfPtsids.Count > 0)
                {
                    MessageBox.Show(listOfPtsids.Count.ToString() + " rows will be archived", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string query1 = "SELECT * FROM p_master WHERE archive <> 1";
                    using (MySqlCommand command1 = new MySqlCommand(query1, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command1))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM p_master WHERE archive = 1";
            command = new MySqlCommand(query, connection);

            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            // Hide button7 when button6 is clicked
            button7.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> selectedRowIds = new List<string>();

            // Iterate over the selected rows in the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkboxCell = (DataGridViewCheckBoxCell)row.Cells["CheckboxColumn"]; // Replace "CheckboxColumn" with your actual checkbox column name

                if (checkboxCell.Value != null && (bool)checkboxCell.Value)
                {
                    string rowId = row.Cells["PTSID"].Value.ToString(); // Replace "PTSID" with the actual column name of the primary key
                    selectedRowIds.Add(rowId);
                }
            }

            // Update the archive status of the selected rows to unarchive them
            UnarchiveRows(selectedRowIds);

            // Refresh the DataGridView to reflect the changes
            dataGridView1.Refresh();
        }

        private void UnarchiveRows(List<string> selectedRowIds)
        {
            try
            {
                connection.Open();

                foreach (string rowId in selectedRowIds)
                {
                    string updateQuery = "UPDATE p_master SET archive = 0 WHERE PTSID = '" + rowId + "'";
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                    updateCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void comboBox_p_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}