using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UpdateCourseRecord
    {
        //class definition: to model the course record dataflow between the user control UpdateRecordControl.cs and the Form NewStudent.cs

        //declare properties
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string CourseLevel { get; set; }
        
    }
}
