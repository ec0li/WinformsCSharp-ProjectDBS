using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using Model;
using UserControls;
using DAL;
using System.Data.SqlClient;

namespace ProjectDBS
{
    public partial class EditStudent : Form
    {
        /*
         * standard declaration of properities/class objs along with 
         * no args constructor that sets the form setting to edit only 
         * (ie read only for StudentNumber/First and Last name)
         */
        public static int SearchStudentID{get; set;}
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public EditStudent()
        {
            InitializeComponent();
            ucUpdateRecordControl1.EditOnly = true;
        }      

        /*
         * Load event from the dgv - student details for editing through vars to event
         * are taken by dgv student number, queried to DB and returned record passed to form 
         */
        private void EditStudent_Load(object sender, EventArgs e)
        {
            int studentID = SearchStudentID;
            dataAdapter = new SqlDataAdapter();
            dataTable = new DataTable();

            DatagridDALProcessing editRecord = new DatagridDALProcessing();
            SqlCommand cmd = editRecord.RetreiveStudentRecord(SearchStudentID);
            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(dataTable);

            int studentNumber = int.Parse(dataTable.Rows[0][0].ToString());
            string firstName = dataTable.Rows[0][1].ToString();
            string lastName = dataTable.Rows[0][2].ToString();
            string email = dataTable.Rows[0][3].ToString();
            string phone = dataTable.Rows[0][4].ToString();
            string addressLine1 = dataTable.Rows[0][5].ToString();  
            string addressLine2 = dataTable.Rows[0][6].ToString();
            string city = dataTable.Rows[0][7].ToString();
            string county = dataTable.Rows[0][8].ToString();
            string level = dataTable.Rows[0][9].ToString();
            
            ucUpdateRecordControl1.DisplayEditRecord.StudentNumber = studentID;
            ucUpdateRecordControl1.DisplayEditRecord.FirstName = firstName;
            ucUpdateRecordControl1.DisplayEditRecord.Surname = lastName;
            ucUpdateRecordControl1.DisplayEditRecord.Email = email;
            ucUpdateRecordControl1.DisplayEditRecord.Phone = phone;
            ucUpdateRecordControl1.DisplayEditRecord.AddressLine1 = addressLine1;
            ucUpdateRecordControl1.DisplayEditRecord.AddressLine2 = addressLine2;
            ucUpdateRecordControl1.DisplayEditRecord.City = city;
            ucUpdateRecordControl1.DisplayEditRecord.County = county;
            ucUpdateRecordControl1.DisplayEditRecord.Level = level;
            //call LoadEditForm helper method 
            LoadEditForm(studentID, firstName, lastName, addressLine1, addressLine2, email, phone, city, county, level);
        }

        /*
         * LoadEditForm helper method to above load event passing data values to the UserControl. 
         * Development Note for this method: It triggers in the above load event a nullreference exception due to
         * the object sender == {unkown} and EventArgs = {unknown}. Looks like they required binding to ucUpdateRecordControl1 which does 
         * not seem to be neccessary at present as the nullreferenece exception for the control registration is not imedping the passing
         * of values to the form form the DB object. Future revisions of this application will relook at this low level bug.
         */
        private void LoadEditForm(int studentID, string firstName, string lastName, string addressLine1, string addressLine2, string email,
            string phone, string city, string county, string level)
        {
            try
            { 
                ucUpdateRecordControl1.DisplayEditRecord.StudentNumber = studentID;
                ucUpdateRecordControl1.DisplayEditRecord.FirstName = firstName;
                ucUpdateRecordControl1.DisplayEditRecord.Surname = lastName;
                ucUpdateRecordControl1.DisplayEditRecord.Email = email;
                ucUpdateRecordControl1.DisplayEditRecord.Phone = phone;
                ucUpdateRecordControl1.DisplayEditRecord.AddressLine1 = addressLine1;
                ucUpdateRecordControl1.DisplayEditRecord.AddressLine2 = addressLine2;
                ucUpdateRecordControl1.DisplayEditRecord.City = city;
                ucUpdateRecordControl1.DisplayEditRecord.County = county;
                ucUpdateRecordControl1.DisplayEditRecord.Level = level;
             }
            catch (NullReferenceException ne)
            {   
                Console.WriteLine(ne.Message);
            }
        }


        /*
         * Button (Home) - Home - Home page code behind
         */
        private void btnHome_Click(object sender, EventArgs e)
        {
            StudentHome goHome = new StudentHome();
            goHome.Show();
            Hide();
        }

        /*
         * Button (Exit) - Exit Button code behind
         */
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult feedback = MessageBox.Show("Are you sure you want to exit the application? Please OK to confirm",
                "System Notice",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(feedback == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        /*
         * Button (Save) - Save Button code behind
         */
        private void btnSave_Click(object sender, EventArgs e)
        {
            AddData updateStudentRecord = new AddData();
            int studentId = ucUpdateRecordControl1.UpdateStudent.StudentNumber;
            string firstName = ucUpdateRecordControl1.UpdateStudent.FirstName;
            string surname = ucUpdateRecordControl1.UpdateStudent.Surname;
            string email = ucUpdateRecordControl1.UpdateStudent.Email;
            string phone = ucUpdateRecordControl1.UpdateStudent.Phone;
            string addressLine1 = ucUpdateRecordControl1.UpdateStudent.AddressLine1;
            string addressLine2 = ucUpdateRecordControl1.UpdateStudent.AddressLine2;
            string city = ucUpdateRecordControl1.UpdateStudent.City;
            string county = ucUpdateRecordControl1.UpdateStudent.County;
            string studentLevel = ucUpdateRecordControl1.UpdateStudent.Level;
            //send updated record to DB
            if (updateStudentRecord.EditStudentRecord(studentId, email, phone, addressLine1, addressLine2, city, county, studentLevel))
            {
                MessageBox.Show("Record Update - Student Record Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ref Student Record Update For: " + firstName + " " + surname + "\nRecord Update Save Failed - Please Revise and Try Again", 
                    "Failed Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*
         * start menu strip code behinds (first word of the method identifier denotes its function)
         */
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult feedback = MessageBox.Show("Are you sure you want to return to the login screen of this application? Please OK to confirm", 
                "System Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (feedback == DialogResult.OK)
            {
                Form1 logout = new Form1();
                logout.Show();
                Hide();
            }
        }
        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult feedback = MessageBox.Show("Are you sure you want to exit the application? Please OK to confirm", 
                "System Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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
        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
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
            DialogResult feedback = MessageBox.Show("Are you sure you want to return to the login screen of this application? Please OK to confirm", 
                "System Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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
