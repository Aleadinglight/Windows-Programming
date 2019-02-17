using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "datasource=mysql.cc.puv.fi;database=e1601117_test;username=" + username.Text + ";password=" + password.Text;

                MySqlConnection mySqlConn = new MySqlConnection(connectionString);
                mySqlConn.Open();

                // Fetch data
                DataSet dataSet = new DataSet();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("Select * from lmao", mySqlConn);
                mySqlDataAdapter.Fill(dataSet, "lmao");
                dataGridView1.DataSource = dataSet.Tables["lmao"].DefaultView;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            /*
                 Show columns from [table]
                 Select [columns] from [table]
                 SELECT DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'lmao' AND COLUMN_NAME = 'sad' 
                 IF EXISTS(SELECT * FROM   dbo.Scores) DROP TABLE dbo.Scores
                 CREATE TABLE Persons ( PersonID int, LastName varchar(255))
                 ALTER TABLE table_name ADD column_name datatype; 
                 INSERT INTO table_name (column1, column2, column3, ...) VALUES (value1, value2, value3, ...); 
             */
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "datasource=mysql.cc.puv.fi;database=e1601117_test;username=" + username.Text + ";password=" + password.Text;

                MySqlConnection mySqlConn = new MySqlConnection(connectionString);
                mySqlConn.Open();
                // Add data

                MySqlCommand mySqlCommand = mySqlConn.CreateCommand();
                mySqlCommand.CommandText = "Insert into lmao (id, name) values (?param1, ?param2)";
                //mySqlCommand.Parameters.AddWithValue("?param", a);
                int a = Int32.Parse(addValue.Text);
                mySqlCommand.Parameters.Add("?param1", MySqlDbType.Int16).Value = a;
                mySqlCommand.Parameters.Add("?param2", MySqlDbType.VarChar).Value = addText.Text;
                mySqlCommand.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "datasource=mysql.cc.puv.fi;database=e1601117_test;username=" + username.Text + ";password=" + password.Text;

                MySqlConnection mySqlConn = new MySqlConnection(connectionString);
                mySqlConn.Open();
                // Add data

                // Fetch data
                DataSet dataSet = new DataSet();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("Select * from lmao where name=?param1", mySqlConn);
                mySqlDataAdapter.SelectCommand.Parameters.Add("?param1", MySqlDbType.VarChar).Value = searchValue.Text;
                mySqlDataAdapter.Fill(dataSet, "lmao");
                dataGridView1.DataSource = dataSet.Tables["lmao"].DefaultView;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
