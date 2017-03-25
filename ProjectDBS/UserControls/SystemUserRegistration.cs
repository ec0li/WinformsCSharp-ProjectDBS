using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BIZ;

namespace UserControls
{
    public partial class ucSystemUserRegistration : UserControl
    {
        //private var for encapsulating data
        private RegisterUser varNewUser;
        public bool EditOnly { get; set; }
        public bool ReadOnly { get; set; }

        //class constructor
        public ucSystemUserRegistration()
        {
            InitializeComponent();
        }

        //property to customise get/set for NewUser property object (RegisterUser class is a Model class)
        public RegisterUser NewUser {
            get
            {
                if (varNewUser == null)
                {
                    varNewUser = new RegisterUser();
                }
                GetData();
                return varNewUser;
            }
            set
            {
                this.varNewUser = value;
            }
        }

        //get data method for Register User property call
        private void GetData()
        {
            try
            {
                //encrypt password
                HashTable hashTable = new HashTable();
                //pass in fields from form to varNewUser object
                int employeeId = 0; //parsing variables
                int.TryParse(txtEmployeeID.Text, out employeeId);
                varNewUser.EmployeeId = employeeId;
                varNewUser.EmployeeUsername = txtUsername.Text;
                varNewUser.Password = hashTable.EncryptPassword(txtPassword.Text);
                varNewUser.EmployeeFirstName = txtFirstName.Text;
                varNewUser.EmployeeLastName = txtLastName.Text;
                varNewUser.JobTitle = txtJobTitle.Text;
                varNewUser.UserType = txtUserType.Text;
                varNewUser.UserStatus = txtUserStatus.Text;
                //Note: from here will pass eventually to Approval table in DB
                varNewUser.ManagerId = txtManagerAuthID.Text;
                varNewUser.ManagerFirstName = txtManagerFirstName.Text;
                varNewUser.ManagerLastName = txtManagerLastName.Text;
                varNewUser.ManagerEmail = txtManagerEmail.Text;
            }
            catch (NullReferenceException ne)
            {
                Console.WriteLine(ne.Message);
            }
        }
        //set up permissions on load
        private void SystemUserRegistration_Load(object sender, EventArgs e)
        {
            txtEmployeeID.Enabled = false; //always read only
            if (EditOnly)
            {
                txtUsername.Enabled = false;
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
            }
            else if (ReadOnly)
            {
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                txtJobTitle.Enabled = false;
                txtUserType.Enabled = false;
                txtUserStatus.Enabled = false;
                txtManagerAuthID.Enabled = false;
                txtManagerFirstName.Enabled = false;
                txtManagerLastName.Enabled = false;
                txtManagerEmail.Enabled = false;
            }
        }
    }
}
