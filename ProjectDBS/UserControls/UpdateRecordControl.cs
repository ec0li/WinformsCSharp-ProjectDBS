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

namespace UserControls
{
    public partial class ucUpdateRecordControl : UserControl
    {
        //Class Definition: Configure the Update Record Control for Read Write (New/View/Edit) in multiple Pres Layer forms.

        //provide provide var for Model property encapsulation
        private UpdateStudentRecord varUpdateStudent; //THIS IS CAUSING AN OBJ INSTANCE NOT SET ISSUE IN ALL CONTROLS

        //declare properties
        public bool ReadOnly { get; set; }
        public bool ReadWrite { get; set; }
        public bool EditOnly { get; set; }
       
        //Class Constructor
        public ucUpdateRecordControl()
        {
            InitializeComponent();
        }

        //overload  contructor
        public ucUpdateRecordControl(int studentNumber, string firstName, string lastName, string email, string phone, string addressLine1,
            string addressLine2, string city, string county, string level)
        {
            txtStudentNumber.Text = studentNumber.ToString();
            txtFirstName.Text = firstName;
            txtSurname.Text = lastName;
            txtEmail.Text = email;
            txtPhone.Text = phone;
            txtStreetAddress.Text = addressLine1;
            txtArea.Text = addressLine2;
            txtCity.Text = city;
            txtCounty.Text = county;
            txtStudentLevel.Text = level;   
        }
        //UpdateStudentRecord property: references the UpdateStudentRecord class in Model - customised get set required for encapsulation
        public UpdateStudentRecord UpdateStudent
        {
            get
            {
                if (varUpdateStudent == null)
                {
                    varUpdateStudent = new UpdateStudentRecord();
                }
                GetData();
                return varUpdateStudent; 
            }
            set
            {
                this.varUpdateStudent = value;
            }
        }
        ////Get Data method called in the UpdateStudentRecord (Model) property
        private void GetData()
        {
            try
            {
                int studentId = 0;
                int.TryParse(txtStudentNumber.Text, out studentId);
                varUpdateStudent.StudentNumber = studentId;
                varUpdateStudent.FirstName = txtFirstName.Text;
                varUpdateStudent.Surname = txtSurname.Text;
                varUpdateStudent.Email = txtEmail.Text;
                varUpdateStudent.Phone = txtPhone.Text;
                varUpdateStudent.AddressLine1 = txtStreetAddress.Text;
                varUpdateStudent.AddressLine2 = txtArea.Text;
                varUpdateStudent.City = txtCity.Text;
                varUpdateStudent.County = txtCounty.Text;
                varUpdateStudent.Level = txtStudentLevel.Text;
            }
            catch (NullReferenceException ne)
            {
                Console.WriteLine(ne.Message);
            }
        }

        //Load event to set acccess field conditions depending on edit rights
        private void UpdateRecordControl_Load(object sender, EventArgs e)
        {
           txtStudentNumber.Enabled = false;
           if (ReadOnly)
            {
                txtStudentNumber.Enabled = false;
                txtFirstName.Enabled = false;
                txtSurname.Enabled = false;
                txtEmail.Enabled = false;
                txtPhone.Enabled = false;
                txtStreetAddress.Enabled = false;
                txtArea.Enabled = false;
                txtCity.Enabled = false;
                txtCounty.Enabled = false;
                txtStudentLevel.Enabled = false;
            }
            else if (EditOnly)
            {
                txtStudentNumber.Enabled = false;
                txtFirstName.Enabled = false;
                txtSurname.Enabled = false;
            }
            //Test Edit student connectivity between user control and form
            if (varUpdateStudent != null)
            {
                txtStudentNumber.Text = varUpdateStudent.StudentNumber.ToString();
                txtFirstName.Text = varUpdateStudent.FirstName;
                txtSurname.Text = varUpdateStudent.Surname;
                txtEmail.Text = varUpdateStudent.Email;
                txtPhone.Text = varUpdateStudent.Phone;
                txtStreetAddress.Text = varUpdateStudent.AddressLine1;
                txtArea.Text = varUpdateStudent.AddressLine2;
                txtCity.Text = varUpdateStudent.City;
                txtCounty.Text = varUpdateStudent.County;
                txtStudentLevel.Text = varUpdateStudent.Level;
            }
        }
    }
}
