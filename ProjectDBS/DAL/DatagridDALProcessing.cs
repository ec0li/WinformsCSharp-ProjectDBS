using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DatagridDALProcessing:DAO
    {
        //Class Definition: to handle DAO requirements from Pres layer relating to  Datagrid operations
        SqlCommand cmd;

        //method 1 call data base using dao for records
        public SqlCommand GetDataDGBaseRecords()
        {
            cmd = OpenConnection().CreateCommand();
            cmd.CommandText = "uspGetEnrollmentDBRecords";
            cmd.CommandType = CommandType.StoredProcedure;
            CloseConnection();
            return cmd;
        }

        //method 2 call to delete student
        public SqlCommand DeleteEnrolledStudent(int recordId)
        {
            cmd = new SqlCommand("uspDeleteEnrolledStudent", OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@enrolledStudentId", recordId);
            cmd.ExecuteScalar();
            CloseConnection();
            return cmd;
        }

        //method 3 call to edit student - this method retreives an indidual record from DB for editing in Edit Screen
        public SqlCommand RetreiveStudentRecord(int studentId)
        {
            cmd = OpenConnection().CreateCommand();
            cmd.CommandText = "uspGetStudentRecord";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@studentId", studentId);
            cmd.ExecuteReader();
            CloseConnection();
            return cmd;
        }
    }
}
