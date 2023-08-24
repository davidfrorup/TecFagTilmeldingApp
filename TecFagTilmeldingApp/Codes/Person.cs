using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecFagTilmeldingApp.Models;
using static TecFagTilmeldingApp.Enums.CountryCodes;

namespace TecFagTilmeldingApp.Codes;

internal abstract class Person
{

    public PersonModel PersonalInfo { get; set; }

    public DateTime BirthDate { get; set; }

    public int Age { get; set; }

    private AgeConverter _ageConverter;

    public Person(string? firstName, string? lastName, DateTime birthDate)
    {
        PersonalInfo = new() { FirstName = firstName, LastName = lastName };
        BirthDate = birthDate;
        Age = new AgeConverter(birthDate).Age;
    }

    public abstract List<string> GetInfo(List<Enrollment> enrollments);

    protected string ShowFullName()
    {
        return $"{PersonalInfo.FirstName} {PersonalInfo.LastName}";
    }

    protected abstract string ShowAllInfo();

    protected virtual string ShowAllInfo2()
    {
        return $"{PersonalInfo.FirstName} {PersonalInfo.LastName}";
    }

    

    public virtual string ShowHolidays()
    {
        return "Holydays not specified.";
    }




    public string ShowBirthDate(CountryCode format = CountryCode.EN)
    {
        DateTime birthDate = BirthDate;
        if (format == CountryCode.DK)
        {
            return birthDate.ToString("dd-MM-yyyy");
        }
        else
        {
            return birthDate.ToString("yyyy-MM-dd");
        }
    }





}



