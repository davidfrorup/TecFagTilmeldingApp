using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Codes
{
    internal class Enrollment
    {

        public Student Student { get; set; }
        public Course? Course { get; set; }

        public Enrollment(Student student, Course? course)
        {
            Student = student;
            Course = course;
        }





    }
}
