using System;
using System.Windows.Forms;
using Model;

namespace UserControls
{
    public partial class ucUpdateRecordControl : UserControl
    {
        /**
         *   Class Definition: Configure the Update Record Control for Read Write (New/View/Edit) in multiple Pres Layer forms.
         */

        //private object declarations (encapsulating dataflow) for use by properties 
        private UpdateStudentRecord varUpdateStudent;
        private UpdateStudentRecord varGetRecord;

        //declare main form properties
        public bool ReadOnly { get; set; }
        public bool ReadWrite { get; set; }
        public bool EditOnly { get; set; }

        //Class Constructor - no args
        public ucUpdateRecordControl()
        {
            InitializeComponent();
        }

        /*
         * Properties: UpdateStudent & DisplayEditRecord for form use posting
         * to DB from user input and displaying from DB for user edit 
         */
        public UpdateStudentRecord UpdateStudent
        {
            get
            {
                if (varUpdateStudent == null && EditOnly == false)
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

        public UpdateStudentRecord DisplayEditRecord
        {
            get
            {
                if (varGetRecord == null)
                {
                    varGetRecord = new UpdateStudentRecord();
                }
                SetData();
                return varGetRecord;
            }
            set
            {
                this.varGetRecord = value;
            }

        }
        /*
         * Helper methods *2 supporting properties - GetData & SetData method 
         * GetData method gets data from form fields and passes to UpdateStudent property for processing to DB
         * SetData method gets data from model object and passes values from DB to form fields for editing
         */

        //GetData prcesses Model object via UpdateStudent property
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
        //SetData processes Model object via DisplayEditRecord property
        private void SetData()
        {
            try
            { 
                txtStudentNumber.Text = varGetRecord.StudentNumber.ToString();
                txtFirstName.Text = varGetRecord.FirstName;
                txtSurname.Text = varGetRecord.Surname;
                txtEmail.Text = varGetRecord.Email;
                txtPhone.Text = varGetRecord.Phone;
                txtStreetAddress.Text = varGetRecord.AddressLine1;
                txtArea.Text = varGetRecord.AddressLine2;
                txtCity.Text = varGetRecord.City;
                txtCounty.Text = varGetRecord.County;
                txtStudentLevel.Text = varGetRecord.Level.ToString();
            }
            catch (NullReferenceException ne)
            {
                Console.WriteLine(ne.Message);
            }
        }

        /*
         * Load event to set acccess field conditions on the form control depending on edit rights
         */
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
        }
    }
}
