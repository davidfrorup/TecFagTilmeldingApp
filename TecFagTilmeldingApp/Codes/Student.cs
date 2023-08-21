using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecFagTilmeldingApp.Models;

namespace TecFagTilmeldingApp.Codes;

internal class Student : Person
{

    public Student (string firstName, string lastName, DateTime birthDate) : base (firstName, lastName, birthDate)
    {
        
    }
}
