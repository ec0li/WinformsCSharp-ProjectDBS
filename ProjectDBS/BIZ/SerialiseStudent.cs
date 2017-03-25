using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class SerialiseStudent
    {
        //class definition: to provide business validation for serialisation of new student file.

        //declare properties (ref: student table)
        public int StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Level { get; set; }

        //default const
        public SerialiseStudent() { }

        //overload for serialisation
        public SerialiseStudent(string firstName, string surname, string email, string phone, string addressLine1, 
            string addressLine2, string city, string county, string studentLevel)
        {
            FirstName = firstName;
            Surname = surname;
            Email = email;
            Phone = phone;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            County = county;
            Level = studentLevel;
        }
    }
}

