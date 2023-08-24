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
        string fullname = ShowFullName();
        string DefaultInfo = ShowAllInfo2();

    }

    public override List<string> GetInfo(List<Enrollment> enrollments)
    {
        List<string> info = new();
        foreach (Enrollment enrollment in enrollments)
        {
            if (enrollment.Course.Teacher.FirstName == PersonalInfo.FirstName && enrollment.Course.Teacher.LastName == PersonalInfo.LastName)
            {
                info.Add(enrollment.Course.Name);
            }
        }

        return info;
    }


    protected override string ShowAllInfo()
    {
        return $"{PersonalInfo.FirstName} {PersonalInfo.LastName}, department {Department}";
    }

    protected override string ShowAllInfo2()
    {
        return $"{PersonalInfo.FirstName} {PersonalInfo.LastName}, department {Department}";
    }


    
    public override string ShowHolidays()
    {
        return "3 weeks summer, and 3 weeks optional holidays.";
    }



}
