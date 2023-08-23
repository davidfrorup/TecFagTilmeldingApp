using System;
using System.Collections.Generic;
using System.IO;
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

    public string WriteText(string valuetoDisplay)
    {
        return $"Hello {valuetoDisplay}";
    }

    public string WriteText(String valuetoDisplay, int alder)
    {
        return $"Hello {valuetoDisplay}, du er {alder}";
    }



}
