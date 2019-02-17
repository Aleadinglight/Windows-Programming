using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
//using MySQLDBConnection;

namespace dbConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString;
            connectionString = "datasource=mysql.cc.puv.fi;database=e1601117_bird;username=e1601117;password=Ah2705Ht";
            Console.Write("Running... \n");
            try
            {
                MySqlConnection mySqlConn = new MySqlConnection(connectionString);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("Select * from bird", mySqlConn);
                DataSet dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet);
                Console.WriteLine("Filled table bird in our data set.");
                Console.WriteLine(dataSet.GetXml());
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);        
            }
        }
    }
}
