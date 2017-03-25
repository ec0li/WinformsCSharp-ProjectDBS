using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class AddData:DAO
    {
        //Class Definition: To Manage the Addition and Updating of Data to the DB via the Dao

        //method 1 - add data for a new customer
        public bool AddNewStudent(int studentId, string firstName, string surname, string email, string phone, string addressLine1, string addressLine2, string city, string county,
            string studentLevel, int courseId, string courseCode, string courseName, string courseLevel)
        {
            bool successfulDBWrite = false;
            try
            {
                SqlCommand cmd = new SqlCommand("uspAddNewStudent", OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@addressLine1", addressLine1);
                cmd.Parameters.AddWithValue("@addressLine2", addressLine2);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@county", county);
                cmd.Parameters.AddWithValue("@studentLevel", studentLevel);
                cmd.Parameters.AddWithValue("@courseId", courseId);
                cmd.Parameters.AddWithValue("@courseCode", courseCode);
                cmd.Parameters.AddWithValue("@courseName", courseName);
                cmd.Parameters.AddWithValue("@courseLevel", courseLevel);
                int successfulDBPosting = cmd.ExecuteNonQuery();
                if (successfulDBPosting == 0)
                {
                    CloseConnection();
                }
                else
                {
                    successfulDBWrite = true;
                    CloseConnection();
                }
                return successfulDBWrite;
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            return successfulDBWrite;
        }

        public bool AddNewUser(int employeeId, string username, string password, string firstName, string lastName, string jobTitle, string userType, string userStatus, string managerAuthId, 
            string managerFirstName, string managerLastName, string managerEmail)
        {
            bool isAddedUser = false;
            try
            {
                //insert new record using a database usp
                SqlCommand cmd = new SqlCommand("uspAddNewUser", OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                cmd.Parameters.AddWithValue("@employeeUserName", username);
                cmd.Parameters.AddWithValue("@employeePassword", password);
                cmd.Parameters.AddWithValue("@employeeFirstName", firstName);
                cmd.Parameters.AddWithValue("@employeeLastName", lastName);
                cmd.Parameters.AddWithValue("@jobTitle", jobTitle);
                cmd.Parameters.AddWithValue("@userType", userType);
                cmd.Parameters.AddWithValue("@userStatus", userStatus);
                cmd.Parameters.AddWithValue("@managerAuthID", managerAuthId);
                cmd.Parameters.AddWithValue("@managerFirstName", managerFirstName);
                cmd.Parameters.AddWithValue("@managerLastName", managerLastName);
                cmd.Parameters.AddWithValue("@managerEmail", managerEmail);
                int postedNewuser = cmd.ExecuteNonQuery();
                if (postedNewuser == 0)
                {
                    CloseConnection();
                }
                else
                {
                    isAddedUser = true;
                    CloseConnection();
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            return isAddedUser;
        }
    }
}
