using System;
using System.Windows.Forms;
using DAL;
using BIZ;
using System.IO;
using System.Xml; //added for XML Serialisation
using System.Xml.Serialization; //added for XML Serialisation


namespace ProjectDBS
{
    public partial class NewStudent : Form
    {
        public NewStudent()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult feedback = MessageBox.Show("Are you sure you want to exit the application? Please OK to confirm", "System Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (feedback == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            StudentHome goHome = new StudentHome();
            goHome.Show();
            Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddData addNewStudent = new AddData(); //DAL Layer class call - no business validation for now
            int studentId = 0;
            int courseId = 0;
            string firstName = ucNewStudentDetails.UpdateStudent.FirstName;
            string surname = ucNewStudentDetails.UpdateStudent.Surname;
            string email = ucNewStudentDetails.UpdateStudent.Email;
            string phone = ucNewStudentDetails.UpdateStudent.Phone;
            string addressLine1 = ucNewStudentDetails.UpdateStudent.AddressLine1;
            string addressLine2 = ucNewStudentDetails.UpdateStudent.AddressLine2;
            string city = ucNewStudentDetails.UpdateStudent.City;
            string county = ucNewStudentDetails.UpdateStudent.County;
            string studentLevel = ucNewStudentDetails.UpdateStudent.Level;
            //from here down is for Course Table
            string courseCode = ucCourseDetailControl1.UpdateCourse.CourseCode;
            string courseName = ucCourseDetailControl1.UpdateCourse.CourseName;
            string courseLevel = ucCourseDetailControl1.UpdateCourse.CourseLevel;
            //use harvested object values in variables to call the add data class and save the information to Student and Course tables
            if (addNewStudent.AddNewStudent(studentId, firstName, surname, email, phone, addressLine1, addressLine2, city, county, studentLevel, 
                courseId, courseCode, courseName, courseLevel))
            {
                MessageBox.Show("New Record Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ref: "+surname+" Course Ref: "+courseCode+"\nNew Record Save Failed - Please Revise and Try Again", "Failed Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSerialise_Click(object sender, EventArgs e)
        {
            //serialisation vars
            string filePath = string.Empty;
            SerialiseStudent serializeStudent = new SerialiseStudent();
            serializeStudent.FirstName = ucNewStudentDetails.UpdateStudent.FirstName;
            serializeStudent.Surname = ucNewStudentDetails.UpdateStudent.Surname;
            serializeStudent.Email = ucNewStudentDetails.UpdateStudent.Email;
            serializeStudent.Phone = ucNewStudentDetails.UpdateStudent.Phone;
            serializeStudent.AddressLine1 = ucNewStudentDetails.UpdateStudent.AddressLine1;
            serializeStudent.AddressLine2 = ucNewStudentDetails.UpdateStudent.AddressLine2;
            serializeStudent.City = ucNewStudentDetails.UpdateStudent.City;
            serializeStudent.County = ucNewStudentDetails.UpdateStudent.County;
            serializeStudent.Level = ucNewStudentDetails.UpdateStudent.Level;
            //other objs
            XmlSerializer serializer;
            XmlWriter writer;


            //routine
            if (serializeStudent != null)
            {
                saveFileDialog.InitialDirectory =@"C:\";
                saveFileDialog.Filter = "XML Files(*.xml)|*.xml";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;
                    serializer = new XmlSerializer(typeof(SerialiseStudent));
                    writer = XmlWriter.Create(filePath);
                    serializer.Serialize(writer, serializeStudent); //serialise the employee object created above
                    MessageBox.Show("Record successfully written to file", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}




