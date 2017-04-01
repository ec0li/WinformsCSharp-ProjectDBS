using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Windows.Forms;
using System.Data.SqlClient;
using Model;

namespace ProjectDBS
{
    public partial class StudentHome : Form
    {
        //constructor
        public StudentHome()
        {
            InitializeComponent();
        }

        //datagrid load and maintanence routines
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        BindingSource bindingSource;

        private void StudentHome_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            UpdateDataGrid();
        }

        /*
         * Helper Methods - LoadDataGrid and UpdateDataGrid to be used in the class for auto updates for StudentHome_Load method and other methods
         */
        //method to load the datagrid view on student home form
        private void LoadDataGrid()
        {
            dgvViewStudentList.AutoGenerateColumns = false;
            dgvViewStudentList.ColumnCount = 5;

            dgvViewStudentList.Columns[0].HeaderText = "Student Number";
            dgvViewStudentList.Columns[0].DataPropertyName = "StudentNumber";

            dgvViewStudentList.Columns[1].HeaderText = "First Name";
            dgvViewStudentList.Columns[1].DataPropertyName = "FirstName";

            dgvViewStudentList.Columns[2].HeaderText = "Surname";
            dgvViewStudentList.Columns[2].DataPropertyName = "Surname";

            dgvViewStudentList.Columns[3].HeaderText = "Course ID";
            dgvViewStudentList.Columns[3].DataPropertyName = "CourseId";

            dgvViewStudentList.Columns[4].HeaderText = "Course Name";
            dgvViewStudentList.Columns[4].DataPropertyName = "CourseName";

            UpdateDataGrid();
        }
        //helper method to update the data grid view
        private void UpdateDataGrid()
        {
            dataAdapter = new SqlDataAdapter();
            dataTable = new DataTable();
            bindingSource = new BindingSource();

            //call dal layer for records to update dgv
            DatagridDALProcessing dgvRecordCall = new DatagridDALProcessing();
            SqlCommand cmd = dgvRecordCall.GetDataDGBaseRecords();

            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;
            dgvViewStudentList.DataSource = bindingSource;
        }

        /*
         * Button (Edit Student) - Edit Student Code behind 
         */
        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            try
            {
                //declare and initialise vars/objs
                int studentID = int.Parse(dgvViewStudentList.SelectedRows[0].Cells[0].Value.ToString());
                //open Edit Student form
                EditStudent editStudent = new EditStudent();
                EditStudent.SearchStudentID = studentID;
                MessageBox.Show("Student ID sent to DB is " + EditStudent.SearchStudentID);
                editStudent.Show();
                Hide();
            }
            catch (ArgumentOutOfRangeException ae)
            {
                MessageBox.Show("Please select a line to edit by clicking on it - No records to Edit until line is Selected", "System Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Something went wrong with the selection - Make Sure You Click on Record before clicking OK", "System Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*
         * Button (Add Student) - New Student - add student code behind
         */                 
        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            NewStudent newStudent = new NewStudent();
            newStudent.Show();
            Hide();
        }

        /*
         * Button (Delete) - Code behind for deleting a student of the Linking Table StudentCourseLT
         */
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            { 
                int delRecordid = (int) dgvViewStudentList.SelectedRows[0].Cells[0].Value;
                //call DAL processing class for the DB Delete
                DatagridDALProcessing delStudent = new DatagridDALProcessing();
                SqlCommand cmd = delStudent.DeleteEnrolledStudent(delRecordid);
                UpdateDataGrid();
            }
            catch (ArgumentOutOfRangeException ae)
            {
                MessageBox.Show("Please select a line to delete by clicking on it - No records to Delete until line is Selected", "System Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Something went wrong with the selection - Make Sure You Click on Record before clicking OK", "System Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*
         * Button (Refresh) - Code behind for refreshing the Datagrid View from the Linking Table StudentCourseLT
         */
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();

        }

        /*
         * Button (Exit) - Code behind for exiting the application
         */
        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult feedback = MessageBox.Show("Are you sure you want to exit the application? Please OK to confirm", "System Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (feedback == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        /*
         * Start Menu Strip Drop Down Selection Code behinds - first word of method identifier indicates its function
         */
        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStudent addNewStudent = new NewStudent();
            addNewStudent.Show();
        }

        private void exitStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStudent editStudent = new EditStudent();
            editStudent.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can see enrolled students on this view", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            logout.Show();
            Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            logout.Show();
            Hide();
        }

        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult feedback = MessageBox.Show("Are you sure you want to exit the application? Please OK to confirm", "System Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (feedback == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }
        //end menu stip code behinds
    }
}
