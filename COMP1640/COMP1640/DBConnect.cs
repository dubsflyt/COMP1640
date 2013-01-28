using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Odbc;
using MySql.Data.MySqlClient;
using MySql.Data.Types;


namespace COMP1640Coursework
{
    public class DBConnect
    {
        public static MySqlConnection GetConnection()
        {
            MySqlConnection con = new MySqlConnection("Server=mysql.cms.gre.ac.uk;Database=mdb_pm005;User ID=pm005;Password=mysqlgre");
          //  con.ConnectionString = "Data Source=studb.cms.gre.ac.uk;Database=mdb_pm005;User ID=pm005;Password=mysqlgre";
            //Default User ID and password is 'root' as 'sa' for Microsoft SQL Server
            // Connection string for a typical local MySQL installation


            // Bind the DataSet
            // ... Place your databinding code here ...
            
            //con.Open();
            return con;
        }

        public static DataSet testMethod(string data)
        {

            string cnnString = "Server=mysql.cms.gre.ac.uk;Database=mdb_pm005;User ID=pm005;Password=mysqlgre";
            MySqlConnection cnx = new MySqlConnection(cnnString);
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            // Create a SQL command object
            string cmdText = "SELECT * FROM Users";
            MySqlCommand cmd = new MySqlCommand(cmdText, cnx);

            // Create a fill a Dataset
            DataSet ds = new DataSet();
            adapter.SelectCommand = cmd;
            adapter.Fill(ds);

           // MySqlDataAdapter dr = new MySqlDataAdapter("select * from users", GetConnection());
           // DataSet ds = new DataSet();
            adapter.Fill(ds);

            return ds;
        }
    }
}