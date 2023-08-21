using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Codes
{
    internal class Teacher
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthOfDate { get; set; }

        public int Age { get; set; }

        public string Afdeling { get; set; }

        public Teacher (string firstName, string lastName, DateTime birthOfDate, int age, string afdeling)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthOfDate = birthOfDate;
            Age = age;
            Afdeling = afdeling;
        }
    }
}
