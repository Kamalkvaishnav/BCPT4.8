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
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace ConsolFromApp
{
    public partial class headCountUserControl1 : UserControl
    {
        string[] columnNames;
        private DataView dataView;
        DateTime currentDate = DateTime.Now;

        public headCountUserControl1()
        {
            InitializeComponent();
            dataGridView1.CellPainting += dataGridView1_CellPainting;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void headCountUserControl1_Load(object sender, EventArgs e)
        {
            dropDownGoc();//this is to get dropdown of GOC id
            //DateTime currentDate = DateTime.Now;
            columnNames = GenerateColumnNames(currentDate);
            //foreach (string columnName in columnNames)
            //{
            //    dataGridView1.Columns.Add(columnName, columnName);
            //}
            //insertGOCAndDescription("");
            maintable();
            Debug.WriteLine(columnNames.Length);
            Debug.WriteLine(dataTable.Columns.Count);
            if (columnNames.Length == dataTable.Columns.Count)
            {
                Debug.WriteLine(dataTable.Columns.Count);

                for (int i = 0; i < columnNames.Length; i++)
                {
                    dataTable.Columns[i].ColumnName = columnNames[i];
                }
            }
            else
            {
                Debug.WriteLine("ELSE");
            }
            // Refresh the DataGridView to reflect the changes
            dataGridView1.Refresh();
            dataView = new DataView(dataTable);




        }
        DataTable dataTable = new DataTable();
        private void maintable()
        {
            string sql1, sql2;
            MySqlCommand cmd1;
            MySqlDataReader dr;
            string connstring = "server=localhost;uid=root;pwd=Y1012Jqkhkp;database=learnings";
            MySqlConnection conn = new MySqlConnection(connstring);
            try
            {
                conn.Open();
                Debug.WriteLine("Inside try before query");
                //sql = "select * from (SELECT allocation_master.month,allocation_master.year,resource_master.goc,sum(allocation_master.allocation) as hr  FROM allocation_master  INNER JOIN resource_master  ON allocation_master.SOEID=resource_master.SOEID GROUP BY allocation_master.month,allocation_master.year,resource_master.goc) as new_table; SELECT  goc ,  -- CONCAT(month, '-', year) AS `Month-Year`,  SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(date_sub(CURRENT_DATE(), INTERVAL 5 MONTH)), '-', YEAR(date_sub(CURRENT_DATE(), INTERVAL 5 MONTH))) THEN `hr` END) AS '1-2023',  SUM(CASE WHEN CONCAT(month, '/', year) = '2/2023' THEN `hr` END) AS `Feb 2023` FROM new_table GROUP BY goc;";
                //sql = "select * from (SELECT allocation_master.month,allocation_master.year,resource_master.goc,sum(allocation_master.allocation) as hr FROM allocation_master INNER JOIN resource_master  ON allocation_master.SOEID=resource_master.SOEID GROUP BY allocation_master.month,allocation_master.year,resource_master.goc) as new_table; SELECT goc , SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(date_sub(CURRENT_DATE(), INTERVAL 5 MONTH)), '-', YEAR(date_sub(CURRENT_DATE(), INTERVAL 5 MONTH))) THEN `hr` END) AS '1-2023', SUM(CASE WHEN CONCAT(month, '/', year) = '2/2023' THEN `hr` END) AS `Feb 2023` FROM new_table GROUP BY goc;";
                //sql1 = "select * from (SELECT allocation_master.month,allocation_master.year,resource_master.goc,sum(allocation_master.allocation) as hr FROM allocation_master INNER JOIN resource_master  ON allocation_master.SOEID=resource_master.SOEID GROUP BY allocation_master.month,allocation_master.year,resource_master.goc) as new_table;";
                //sql2 = "SELECT goc , SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(date_sub(CURRENT_DATE(), INTERVAL 5 MONTH)), '-', YEAR(date_sub(CURRENT_DATE(), INTERVAL 5 MONTH))) THEN `hr` END) AS '1-2023', SUM(CASE WHEN CONCAT(month, '/', year) = '2/2023' THEN `hr` END) AS `Feb 2023` FROM new_table GROUP BY goc;";
                //sql1 = "SELECT * FROM allocation_master";
                //sql2 = "SELECT * FROM gocmaster";
                //sql1 = "SELECT goc, SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(date_sub(CURRENT_DATE(), INTERVAL 5 MONTH)), '-', YEAR(date_sub(CURRENT_DATE(), INTERVAL 5 MONTH))) THEN `hr` END) AS '1-2023', SUM(CASE WHEN CONCAT(month, '/', year) = '2/2023' THEN `hr` END) AS `Feb 2023` FROM (SELECT allocation_master.month, allocation_master.year, resource_master.goc, SUM(allocation_master.allocation) AS hr FROM allocation_master INNER JOIN resource_master ON allocation_master.SOEID = resource_master.SOEID GROUP BY allocation_master.month, allocation_master.year, resource_master.goc ) AS new_table GROUP BY goc;\r\n";
                //sql1 = "SELECT goc, SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -6 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -6 MONTH))) THEN `hr` END) AS 'Column1', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -5 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -5 MONTH))) THEN `hr` END) AS 'Column2', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -4 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -4 MONTH))) THEN `hr` END) AS 'Column3', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -3 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -3 MONTH))) THEN `hr` END) AS 'Column4', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -2 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -2 MONTH))) THEN `hr` END) AS 'Column5', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -1 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -1 MONTH))) THEN `hr` END) AS 'Column6', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 0 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 0 MONTH))) THEN `hr` END) AS 'Column7', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 1 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 1 MONTH))) THEN `hr` END) AS 'Column8', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 2 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 2 MONTH))) THEN `hr` END) AS 'Column9', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 3 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 3 MONTH))) THEN `hr` END) AS 'Column10', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 4 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 4 MONTH))) THEN `hr` END) AS 'Column11', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 5 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 5 MONTH))) THEN `hr` END) AS 'Column12', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 6 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 6 MONTH))) THEN `hr` END) AS 'Column13' FROM (SELECT allocation_master.month, allocation_master.year, resource_master.goc, SUM(allocation_master.allocation) AS hr FROM allocation_master INNER JOIN resource_master ON allocation_master.SOEID = resource_master.SOEID GROUP BY allocation_master.month, allocation_master.year, resource_master.goc) AS new_table GROUP BY goc;";
                sql1 = "SELECT new_table.goc,gocmaster.goc_description, SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -6 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -6 MONTH))) THEN `hr` END) AS 'Column1', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -5 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -5 MONTH))) THEN `hr` END) AS 'Column2', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -4 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -4 MONTH))) THEN `hr` END) AS 'Column3', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -3 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -3 MONTH))) THEN `hr` END) AS 'Column4', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -2 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -2 MONTH))) THEN `hr` END) AS 'Column5', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -1 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -1 MONTH))) THEN `hr` END) AS 'Column6', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 0 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 0 MONTH))) THEN `hr` END) AS 'Column7', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 1 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 1 MONTH))) THEN `hr` END) AS 'Column8', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 2 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 2 MONTH))) THEN `hr` END) AS 'Column9', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 3 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 3 MONTH))) THEN `hr` END) AS 'Column10', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 4 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 4 MONTH))) THEN `hr` END) AS 'Column11', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 5 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 5 MONTH))) THEN `hr` END) AS 'Column12', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 6 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 6 MONTH))) THEN `hr` END) AS 'Column13' FROM (SELECT allocation_master.month, allocation_master.year, resource_master.goc, SUM(allocation_master.allocation) AS hr FROM allocation_master INNER JOIN resource_master ON allocation_master.SOEID = resource_master.SOEID GROUP BY allocation_master.month, allocation_master.year, resource_master.goc) AS new_table INNER JOIN gocmaster ON gocmaster.goc=new_table.goc GROUP BY new_table.goc;";
                cmd1 = new MySqlCommand(sql1, conn);
                //cmd2 = new MySqlCommand(sql2w, conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd1);

                adapter.Fill(dataTable);
                //DataSet dataSet = new DataSet();
                dataGridView1.DataSource = dataTable;
                //dataGridView1.Height = (dataGridView1.RowCount + 2) * dataGridView1.RowTemplate.Height;

                //Debug.WriteLine(dataSet.Tables.Count);

                //adapter.Fill(dataSet);
                //Debug.WriteLine("Inside try after query 4");
                //if (dataSet.Tables.Count >= 2)
                //{
                //    Debug.WriteLine("Inside if before query");
                //    DataTable dataTable = dataSet.Tables[1];
                //    dataGridView1.DataSource = dataTable;
                //    Debug.WriteLine("Inside if after query");
                //}
                //else
                //{
                //    Debug.WriteLine("Inside else before query");
                //    DataTable dataTable = dataSet;
                //    dataGridView1.DataSource = dataTable;
                //    Debug.WriteLine("Inside else after query");
                //}



            }
            catch
            {
                MessageBox.Show("Some Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }

        public void dropDownGoc()
        {
            string sql;
            MySqlCommand cmd;
            MySqlDataReader dr;
            string connstring = "server=localhost;uid=root;pwd=Y1012Jqkhkp;database=learnings";
            MySqlConnection conn = new MySqlConnection(connstring);
            try
            {
                conn.Open();
                sql = "SELECT * FROM gocmaster";
                cmd = new MySqlCommand(sql, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string gocId = dr.GetString(0);//0 is index in database
                    string gocDescription = dr.GetString(3);
                    string gocAll = gocId + " - " + gocDescription;
                    dropDownForGocComboBox.Items.Add(gocAll);
                }


            }
            catch
            {
                MessageBox.Show("Invalid GOC Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        static string[] GenerateColumnNames(DateTime currentDate)
        {
            string[] columnNames = new string[15];
            columnNames[0] = "GOC ID";
            columnNames[1] = "Description";
            for (int i = -6; i <= 6; i++)
            {
                DateTime previousMonth = currentDate.AddMonths(i);
                columnNames[i + 8] = previousMonth.ToString("MMM-yyyy");


            }
            return columnNames;
        }

        //public void insertGOCAndDescription(string selectedItem)
        //{
        //    int i = 0;
        //    string sql;
        //    MySqlCommand cmd;
        //    MySqlDataReader dr;
        //    string connstring = "server=localhost;uid=root;pwd=Y1012Jqkhkp;database=learnings";
        //    MySqlConnection conn = new MySqlConnection(connstring);
        //    conn.Open();

        //    sql = "SELECT * FROM gocmaster";
        //    cmd = new MySqlCommand(sql, conn);
        //    dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        int gocId = dr.GetInt32(0); //0 is index in database
        //        string gocDescription = dr.GetString(3);
        //        // Create a new row
        //        DataGridViewRow newRow = new DataGridViewRow();
        //        newRow.CreateCells(dataGridView1);

        //        // Set the value for the first column of the new row
        //        newRow.Cells[0].Value = gocId;

        //        // Add the new row to the DataGridView
        //        dataGridView1.Rows.Add(newRow);

        //        dataGridView1.Rows[i].Cells[1].Value = gocDescription; //3 is the index to goc description in the database
        //        i++;
        //    }
        //    conn.Close();


        //}




        private void dropDownForGocComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (dropDownForGocComboBox.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();

                string selectedItem = dropDownForGocComboBox.SelectedItem.ToString();
                MySqlCommand cmd1;
                string connstring = "server=localhost;uid=root;pwd=Y1012Jqkhkp;database=learnings";
                MySqlConnection conn = new MySqlConnection(connstring);
                conn.Open();
                string sql1 = "SELECT new_table.goc,gocmaster.goc_description, SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -6 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -6 MONTH))) THEN `hr` END) AS 'Column1', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -5 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -5 MONTH))) THEN `hr` END) AS 'Column2', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -4 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -4 MONTH))) THEN `hr` END) AS 'Column3', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -3 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -3 MONTH))) THEN `hr` END) AS 'Column4', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -2 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -2 MONTH))) THEN `hr` END) AS 'Column5', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -1 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -1 MONTH))) THEN `hr` END) AS 'Column6', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 0 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 0 MONTH))) THEN `hr` END) AS 'Column7', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 1 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 1 MONTH))) THEN `hr` END) AS 'Column8', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 2 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 2 MONTH))) THEN `hr` END) AS 'Column9', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 3 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 3 MONTH))) THEN `hr` END) AS 'Column10', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 4 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 4 MONTH))) THEN `hr` END) AS 'Column11', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 5 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 5 MONTH))) THEN `hr` END) AS 'Column12', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 6 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 6 MONTH))) THEN `hr` END) AS 'Column13' FROM (SELECT allocation_master.month, allocation_master.year, resource_master.goc, SUM(allocation_master.allocation) AS hr FROM allocation_master INNER JOIN resource_master ON allocation_master.SOEID = resource_master.SOEID GROUP BY allocation_master.month, allocation_master.year, resource_master.goc) AS new_table INNER JOIN gocmaster ON gocmaster.goc=new_table.goc where new_table.goc=" + selectedItem + " GROUP BY new_table.goc;";
                cmd1 = new MySqlCommand(sql1, conn);


                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd1);

                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                for (int i = 0; i < columnNames.Length; i++)
                {
                    dt.Columns[i].ColumnName = columnNames[i];
                }
                //dataGridView1.Height = (dataGridView1.RowCount + 2) * dataGridView1.RowTemplate.Height;
                dataGridView1.Refresh();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            if (dropDownForGocComboBox.SelectedIndex != -1)
            {
                string selectedItem = dropDownForGocComboBox.SelectedItem.ToString();
                MySqlCommand cmd1;
                string connstring = "server=localhost;uid=root;pwd=Y1012Jqkhkp;database=learnings";
                MySqlConnection conn = new MySqlConnection(connstring);
                conn.Open();
                string sql1 = "SELECT new_table.goc,gocmaster.goc_description, SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -6 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -6 MONTH))) THEN `hr` END) AS 'Column1', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -5 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -5 MONTH))) THEN `hr` END) AS 'Column2', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -4 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -4 MONTH))) THEN `hr` END) AS 'Column3', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -3 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -3 MONTH))) THEN `hr` END) AS 'Column4', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -2 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -2 MONTH))) THEN `hr` END) AS 'Column5', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL -1 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL -1 MONTH))) THEN `hr` END) AS 'Column6', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 0 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 0 MONTH))) THEN `hr` END) AS 'Column7', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 1 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 1 MONTH))) THEN `hr` END) AS 'Column8', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 2 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 2 MONTH))) THEN `hr` END) AS 'Column9', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 3 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 3 MONTH))) THEN `hr` END) AS 'Column10', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 4 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 4 MONTH))) THEN `hr` END) AS 'Column11', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 5 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 5 MONTH))) THEN `hr` END) AS 'Column12', SUM(CASE WHEN CONCAT(month, '-', year) = CONCAT(MONTH(DATE_ADD(CURRENT_DATE(), INTERVAL 6 MONTH)), '-',  YEAR(DATE_ADD(CURRENT_DATE(), INTERVAL 6 MONTH))) THEN `hr` END) AS 'Column13' FROM (SELECT allocation_master.month, allocation_master.year, resource_master.goc, SUM(allocation_master.allocation) AS hr FROM allocation_master INNER JOIN resource_master ON allocation_master.SOEID = resource_master.SOEID GROUP BY allocation_master.month, allocation_master.year, resource_master.goc) AS new_table INNER JOIN gocmaster ON gocmaster.goc=new_table.goc where new_table.goc GROUP BY new_table.goc;";
                cmd1 = new MySqlCommand(sql1, conn);


                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd1);

                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                for (int i = 0; i < columnNames.Length; i++)
                {
                    dt.Columns[i].ColumnName = columnNames[i];
                }
                //dataGridView1.Height = (dataGridView1.RowCount + 2) * dataGridView1.RowTemplate.Height;
                dataGridView1.Refresh();

            }
            dropDownForGocComboBox.SelectedIndex = -1;
        }

        //to highlight the current month
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 8) // Specify the column index for which you want to change the header color
            {
                // Change the header color
                e.CellStyle.BackColor = Color.Yellow;
                //e.CellStyle.ForeColor = Color.Black;

                // Optionally, you can customize other header properties as well
                //e.CellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

                // Prevent the default painting
                //e.Handled = true;
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
