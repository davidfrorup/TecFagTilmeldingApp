using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecFagTilmeldingApp.Models;

namespace TecFagTilmeldingApp.Codes;

internal class Person
{

    public PersonModel PersonalInfo { get; set; }

    public DateTime BirthDate { get; set; }

    public int Age { get; set; }

    private AgeConverter _ageConverter;

    public Person(string firstName, string lastName, DateTime birthDate)
    {
        PersonalInfo = new() { FirstName = firstName, LastName = lastName };
        BirthDate = birthDate;
        _ageConverter._age = DateTime.Now.Year - birthDate.Year;
        Age = _ageConverter._age;

        //Age = new AgeConverter(birthDate).Age;
        //SetAge(birthDate);   
    }

    /* public void SetAge(DateTime birthDate)
     {
         Age = new AgeConverter(birthDate).Age;
     } */


}



