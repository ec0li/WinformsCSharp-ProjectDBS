using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAL
{
    public class DAO
    {
        //Class Definition: to provide connectivity to the database for the entire solution
        SqlConnection conn;

        //Overload constructor with Database intitalisation string from app.config.
        public DAO()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString);
        }

        //Method 1 - Open DB Connection
        public SqlConnection OpenConnection()

        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        //method 2 closing the connection
        public void CloseConnection()
        {
            if (conn != null)
            {
                if (conn.State == ConnectionState.Open || conn.State == ConnectionState.Broken)
                {
                    conn.Close();
                }
            }
        }
    }
}
