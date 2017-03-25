using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIZ;
using DAL;
using UserControls;

namespace ProjectDBS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true; //hides the password chars as you enter them
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult feedback = MessageBox.Show("Are you sure you want to exit the application? Please OK to confirm", "System Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (feedback == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SysUserRegistration newUser = new SysUserRegistration();
            newUser.Show();
            Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            HashTable hashTable = new HashTable(); //process class in BIZ layer for SHA1 encryption
            string username = txtUsername.Text;
            string password = hashTable.EncryptPassword(txtPassword.Text);

            //Call DAL Layer for Processing Login Auth against DB
            LoginDALProcessing processLogin = new LoginDALProcessing();
            if (processLogin.AuthenticateUserDetails(username, password))
            {
                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StudentHome succesfulLogin = new StudentHome();
                succesfulLogin.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Login Failed - Please Try Again", "Failed Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void menuLogin_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show("You must login to use the menu bar", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuLogin.Enabled = false;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
