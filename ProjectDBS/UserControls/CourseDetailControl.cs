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
    public partial class ucCourseDetailControl : UserControl
    {
        //Class Definition: To Process the Course Input Details which will be assigned to students

        //declare member var for wrapping in Biz/Model property and customising the property UpdateCourse to handle the data correctly
        private UpdateCourseRecord varUpdateCourse;

        //Declare properties
        public bool ReadOnly { get; set; }

        public UpdateCourseRecord UpdateCourse {
            get
            {
                if (varUpdateCourse == null)
                {
                    varUpdateCourse = new UpdateCourseRecord();
                }
                GetData(); //method see below
                return varUpdateCourse;
            }
            set
            {
                this.varUpdateCourse = value;
            }
        }
        //method to obtain all data from the user control text boxes (CourseDetailControl) assigning in property call above
        private void GetData()
        {
            try { 
                varUpdateCourse.CourseCode = txtCourseCode.Text;
                varUpdateCourse.CourseName = txtCourseName.Text;
                varUpdateCourse.CourseLevel = txtCourseLevel.Text;
            }
            catch (NullReferenceException ne)
            {
                string nullRefMessage = ne.Message;
            }
        }

        public ucCourseDetailControl()
        {
            InitializeComponent();
        }

        private void CourseDetailControl_Load(object sender, EventArgs e)
        {
            if (ReadOnly)
            {
                txtCourseCode.Enabled = false;
                txtCourseName.Enabled = false;
                txtCourseLevel.Enabled = false;
            }

            //test to ensure connectivity with the form NewStudents.cs
            if (varUpdateCourse != null)
            {
                txtCourseCode.Text = varUpdateCourse.CourseCode;
                txtCourseName.Text = varUpdateCourse.CourseName;
                txtCourseLevel.Text = varUpdateCourse.CourseLevel; //revise combo box assignment
            }
        }
    }
}
