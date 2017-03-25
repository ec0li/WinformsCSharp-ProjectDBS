using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using UserControls;
using DAL;
namespace ProjectDBS
{
    public partial class SysUserRegistration : Form
    {
        public SysUserRegistration()
        {
            InitializeComponent();
        }

        //ensure employeeId is write only
        private void SysUserRegistration_Load(object sender, EventArgs e)
        {
            menuNewStudent.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult feedback = MessageBox.Show("Are you sure you want to exit the application? Please OK to confirm", "System Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (feedback == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            AddData addingNewUser = new AddData(); //call DAL Add Data class for DB access
            //add variables passing in form values for the new registration
            int employeeId = 0;
            string username = ucSystemUserRegistration1.NewUser.EmployeeUsername;
            string password = ucSystemUserRegistration1.NewUser.Password;
            string firstName = ucSystemUserRegistration1.NewUser.EmployeeFirstName;
            string lastName = ucSystemUserRegistration1.NewUser.EmployeeLastName;
            string jobTitle = ucSystemUserRegistration1.NewUser.JobTitle;
            string userType = ucSystemUserRegistration1.NewUser.UserType;
            string userStatus = ucSystemUserRegistration1.NewUser.UserStatus;
            string managerAuthId = ucSystemUserRegistration1.NewUser.ManagerId;
            string managerFirstName = ucSystemUserRegistration1.NewUser.ManagerFirstName;
            string managerLastName = ucSystemUserRegistration1.NewUser.ManagerLastName;
            string managerEmail = ucSystemUserRegistration1.NewUser.ManagerEmail;

            if (addingNewUser.AddNewUser(employeeId, username, password, firstName, lastName, jobTitle, userType, userStatus, 
                managerAuthId, managerFirstName, managerLastName, managerEmail))
            {
                MessageBox.Show("Successfully Added " + lastName + " as " + username, "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Failed to Add " + lastName + " as " + username+". Please review entry", "Failed Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult feedback = MessageBox.Show("Are you sure you want to return to the login screen of this application? Please OK to confirm", "System Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (feedback == DialogResult.OK)
            {
                Form1 logout = new Form1();
                logout.Show();
                Hide();
            }
        }

        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult feedback = MessageBox.Show("Are you sure you want to exit the application? Please OK to confirm", "System Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (feedback == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }
    }
}
