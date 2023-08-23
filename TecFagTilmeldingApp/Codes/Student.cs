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

    protected override string ShowAllInfo()
    {
        return $"{PersonalInfo.FirstName} {PersonalInfo.LastName}";
    }

    public override string GetInfo(List<Enrollment> enrollments)
    {
        var studentEnrollments = enrollments.Where(e => e.Student == this).Select(e => e.Course.Name).ToList();
        return $"Elev: {PersonalInfo.FirstName} {PersonalInfo.LastName}\nTilmeldte fag: {string.Join(", ", studentEnrollments)}";
    }


    public override string ShowHolidays()
    {
        return "6 weeks summer, and 2 weeks Christmas holidays.";
    }




}
