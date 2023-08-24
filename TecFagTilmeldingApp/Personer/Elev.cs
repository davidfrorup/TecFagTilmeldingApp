using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecFagTilmeldingApp.Models;
using TecFagTilmeldingApp.Codes;

namespace TecFagTilmeldingApp.Personer;

internal sealed class Elev : Person
{

    public Elev(string firstName, string lastName, DateTime birthDate) : base(firstName, lastName, birthDate)
    {
        
    }


    public void Greet()
    {
        string hilsen = SayHello("elev", PersonalInfo.FirstName);
        Console.WriteLine(hilsen);
    }


    public override string ShowMyIdentity()
    {
        return "Jeg er en elev.";
    }

}
