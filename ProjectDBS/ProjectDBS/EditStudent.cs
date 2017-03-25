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
using System.Data.SqlClient;

namespace ProjectDBS
{
    public partial class EditStudent : Form
    {
        //properities/class objs
        public static int SearchStudentID{get; set;}
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        BindingSource bindingSource;

        //Constructor
        public EditStudent()
        {
            InitializeComponent();
            ucUpdateRecordControl1.EditOnly = true;
        }
        //Load event from the dgv - student details for editing (NOT WORKING YET)
        private void EditStudent_Load(object sender, EventArgs e)
        {
            int studentID = SearchStudentID;
            DatagridDALProcessing editRecord = new DatagridDALProcessing();
            SqlCommand cmd = editRecord.RetreiveStudentRecord(SearchStudentID);
           // UpdateStudentRecord editStudent = new UpdateStudentRecord(); //pass values to form
            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(dataTable);
            //bindingSource.DataSource = dataTable;
            int studentNumber = int.Parse(dataTable.Rows[0][0].ToString());
            string firstName = dataTable.Rows[0][1].ToString();
            string lastname = dataTable.Rows[0][2].ToString();
            string email = dataTable.Rows[0][3].ToString();
            string phone = dataTable.Rows[0][4].ToString();
            string addressLine1 = dataTable.Rows[0][5].ToString();
            string addressLine2 = dataTable.Rows[0][6].ToString();
            string city = dataTable.Rows[0][7].ToString();
            string county = dataTable.Rows[0][8].ToString();
            string level = dataTable.Rows[0][9].ToString();
            //pass obj to control
            ucUpdateRecordControl update = new ucUpdateRecordControl(studentNumber, firstName, lastname, email, phone, addressLine1, addressLine2, city, county, level);
            //to be finished....
        }
        //Home button
        private void btnHome_Click(object sender, EventArgs e)
        {
            StudentHome goHome = new StudentHome();
            goHome.Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult feedback = MessageBox.Show("Are you sure you want to exit the application? Please OK to confirm","System Notice",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(feedback == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        //start menu strip code behinds
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
        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStudent addNewStudent = new NewStudent();
            addNewStudent.Show();
        }
        private void exitStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can edit students on this view", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            StudentHome gohome = new StudentHome();
            gohome.Show();
            Hide();
        }
        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult feedback = MessageBox.Show("Are you sure you want to return to the login screen of this application? Please OK to confirm", "System Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (feedback == DialogResult.OK)
            {
                Form1 logout = new Form1();
                logout.Show();
                Hide();
            }
        }
        //end menu strip code behinds
    }
}
