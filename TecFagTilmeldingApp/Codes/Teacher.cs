using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecFagTilmeldingApp.Models;

namespace TecFagTilmeldingApp.Codes;

internal class Teacher : Person
{

    public string Department { get; set; }

    public Teacher (string firstName, string lastName, DateTime birthDate, string department) : base(firstName, lastName, birthDate)
    {
        Department = department;
    }
}
