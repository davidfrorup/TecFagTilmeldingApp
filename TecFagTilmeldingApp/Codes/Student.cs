using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Codes
{
    internal class Student
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }    

        public DateTime BirthOfDate { get; set; }

        public int Age { get; set; }

        public Student (string firstName, string lastName, DateTime birthOfDate, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthOfDate = birthOfDate;
            Age = age;
        }
    }
}
