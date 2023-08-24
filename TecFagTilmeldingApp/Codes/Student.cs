using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecFagTilmeldingApp.Models;

namespace TecFagTilmeldingApp.Codes;

internal class Student : Person
{
    public List<Course> Courses { get; } = new List<Course>();
    public Student (string firstName, string lastName, DateTime birthDate) : base (firstName, lastName, birthDate)
    {
        string DefaultInfo = ShowAllInfo2();
    }

    public void EnrollCourse(Course course)
    {
        Courses.Add(course); 
    }



    public override List<string> GetInfo(List<Enrollment> enrollments)
    {
        List<string> info = new();
        foreach (Enrollment enrollment in enrollments)
        {
            if (enrollment.Student.PersonalInfo.FirstName == PersonalInfo.FirstName && enrollment.Student.PersonalInfo.LastName == PersonalInfo.LastName)
            {
                info.Add(enrollment.Course.Name);
            }
        }

        return info;
    }


    protected override string ShowAllInfo()
    {
        return $"{PersonalInfo.FirstName} {PersonalInfo.LastName}";
    }


    public override string ShowHolidays()
    {
        return "6 weeks summer, and 2 weeks Christmas holidays.";
    }




}
