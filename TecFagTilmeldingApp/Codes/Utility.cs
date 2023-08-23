using System;
using System.Collections.Generic;
using TecFagTilmeldingApp.Codes;

namespace TecFagTilmeldingApp.Codes
{
    internal static class Utility
    {

        static List<Teacher> teachers = new List<Teacher>();
        public static List<Teacher> CreateTeachers()
        {
            
            teachers.Add(new Teacher("Niels", "Olesen", new DateTime(1971, 2, 23), "CIT"));
            teachers.Add(new Teacher("Henrik", "Paulsen", new DateTime(1971, 2, 23), "CIT"));
            teachers.Add(new Teacher("Jack", "Baltzer", new DateTime(1971, 2, 23), "CIT"));
            teachers.Add(new Teacher("Bo", "Elbæk", new DateTime(1971, 2, 23), "CIT"));

            return teachers;
        }

        public static List<Course> CreateCourses(List<Teacher> teachers)
        {
            List<Course> courses = new List<Course>();

            courses.Add(new Course("Grundlæggende programmering", teachers[0].PersonalInfo));
            courses.Add(new Course("OOP", teachers[0].PersonalInfo));
            courses.Add(new Course("Studieteknik", teachers[0].PersonalInfo));
            courses.Add(new Course("Netværk", teachers[1].PersonalInfo));
            courses.Add(new Course("Clientside programmering", teachers[2].PersonalInfo));
            courses.Add(new Course("Database programmering", teachers[2].PersonalInfo));
            courses.Add(new Course("Computerteknologi", teachers[3].PersonalInfo));

            return courses;
        }
    }
}
