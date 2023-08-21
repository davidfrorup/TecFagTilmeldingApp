using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecFagTilmeldingApp.Models;

namespace TecFagTilmeldingApp.Codes;

internal class Course
{

    public string Name { get; set; }

    public PersonModel Teacher { get; set; }


    public Course(string name, PersonModel teacher)
    {

        Name = name;
        Teacher = teacher;

    }

}
