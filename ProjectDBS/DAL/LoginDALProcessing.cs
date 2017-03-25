using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class LoginDALProcessing : DAO
    {
        //class definition: process the user name and password from login to authenticate against DB

        //method 1 = Method to check employee login details against DB
        public bool AuthenticateUserDetails(string username, string password)
        {
            //vars
            bool isValidUser = false;
            SqlDataReader reader;

            try
            {
                SqlCommand cmd = new SqlCommand("uspAuthDBUserCreds", OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isValidUser = true;
                    CloseConnection();
                }
                else
                {
                    CloseConnection();
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            return isValidUser;
        }
    }
}
