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

    protected override string ShowAllInfo()
    {
        return $"{PersonalInfo.FirstName} {PersonalInfo.LastName}, department {Department}";
    }

    protected override string ShowAllInfo2()
    {
        return $"{PersonalInfo.FirstName} {PersonalInfo.LastName}, department {Department}";
    }

    public string GetInfo(List<Enrollment> enrollments)
    {
        var relevantEnrollments = enrollments.Where(enrollment => enrollment.Teacher == this).Select(enrollment => enrollment.Course);

        StringBuilder info = new StringBuilder();

        info.AppendLine($"{PersonalInfo.FirstName} {PersonalInfo.LastName} underviser i følgende kurser:");

        foreach (var course in relevantEnrollments)
        {
            info.AppendLine(course.Name);
        }

        return info.ToString();
    }

    
    public override string ShowHolidays()
    {
        return "3 weeks summer, and 3 weeks optional holidays.";
    }



}
