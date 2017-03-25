using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RegisterUser
    {
        //Class Definition: Receive data from the form for passing through to user controls as circular reference workaround
        //Declare properties (ref Employee Table) 
        public int EmployeeId { get; set; }
        public string EmployeeUsername { get; set; }
        public string Password { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string JobTitle { get; set; }
        public string UserType { get; set; }
        public string UserStatus { get; set; }
        //declare properites (ref: ApprovalTable)
        public string  ManagerId { get; set; }
        public string ManagerFirstName { get; set; }
        public string ManagerLastName { get; set; }
        public string ManagerEmail { get; set; }
       // public int ManagerEmployeeId { get; set; } //will be populateed from Employee table in FK reference, for testing ONLY
    }
}
