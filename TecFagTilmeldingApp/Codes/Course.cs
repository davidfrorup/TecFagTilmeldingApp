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

    public string WriteText(string valueToDisplay)
    {
        return $"Hello {valueToDisplay}!";
    }

    public string WriteText(string valueToDisplay, int alder)
    {
        return $"Hello {valueToDisplay}!, du er {alder.ToString()} år gammel.";
    }



}
