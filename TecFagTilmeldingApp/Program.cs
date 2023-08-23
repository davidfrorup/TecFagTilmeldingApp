// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;
using TecFagTilmeldingApp.Codes;
using TecFagTilmeldingApp.Models;


// https://prod.liveshare.vsengsaas.visualstudio.com/join?880C701B0C1EFF4EF3306C775FFB97016F1B



/*DateTime birthDate = new DateTime(1971, 2, 23);
Teacher niels = new("Niels", "Olesen", birthDate, "CIT");
PersonModel personalInfo = niels.PersonalInfo;

Course oop = new("OOP", personalInfo);

Console.WriteLine($"{oop.Name} Teacher: {personalInfo.FirstName} {personalInfo.LastName}");
*/

//DateTime nielsbirthDate = new DateTime(1971, 2, 23);
//DateTime patrikbirthDate = new DateTime(2001, 2, 23);


//Teacher niels = new("Niels", "Olesen", new DateTime(1971, 2, 23), "CIT");
//PersonModel nielspersonalInfo = niels.PersonalInfo;
//Student patrik = new("Patrik", "Nielsen", new DateTime(1996, 8, 1));
//PersonModel patrikpersonalInfo = patrik.PersonalInfo;
//Course course = new("OOP", nielspersonalInfo);

//Console.WriteLine($"{course.Name} Teacher: {nielspersonalInfo.FirstName} {nielspersonalInfo.LastName}");

//Console.WriteLine(nielspersonalInfo.FirstName + " alder: " + niels.Age);

//Console.WriteLine(patrikpersonalInfo.FirstName + " alder: " + patrik.Age);

//Console.WriteLine($"{course.Name} lærer er: {nielspersonalInfo.FirstName} {nielspersonalInfo.LastName}");

//Course grundlæggendeProgrammering = new("Grundlæggende programmering", niels.PersonalInfo);
//grundlæggendeProgrammering.WriteText();


while(true)
{
    Console.Write("Indtast tallet 1 for at afspille lyden: ");
    string talInput = Console.ReadLine();

    if (talInput == "1")
    {
        string myCurrentDir = System.IO.Directory.GetCurrentDirectory();
        string appDir = System.IO.Path.Combine(myCurrentDir, @"MySounds\minlyd.wav");

        System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
        soundPlayer.SoundLocation = appDir;
        soundPlayer.Play();
    }

    else
    {
        Console.Clear();
    }
}



List<Enrollment> enrollments = new List<Enrollment>();

List<Student> students = new List<Student>();
List<Course> courses = Utility.CreateCourses(Utility.CreateTeachers());



Console.WriteLine("Ingen elever er tilmeldt endnu");

while (true)
{
    Console.Write("\nAngiv elev fornavn: ");
    string firstName = Console.ReadLine();

    Console.Write("Angiv elev efternavn: ");
    string lastName = Console.ReadLine();

    Console.Write("Angiv elev fødselsdato (YYYY-MM-DD): ");
    if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
    {
        Course selectedCourse = SelectCourse(courses);
        if (selectedCourse != null)
        {
            Student student = new Student(firstName, lastName, birthDate);
            student.EnrollCourse(selectedCourse);
            students.Add(student);

            // Tilføj tilmeldingen til enrollments
            enrollments.Add(new Enrollment(student, selectedCourse, null));

            Console.WriteLine($"\n{student.PersonalInfo.FirstName} {student.PersonalInfo.LastName} er nu tilmeldt {selectedCourse.Name}");
        }
        else
        {
            Console.WriteLine("Ugyldigt fag-id.");
        }

        Console.Write("\nTilmeld ny elev [J/N]: ");
        ConsoleKeyInfo keyInfo;
        do
        {
            keyInfo = Console.ReadKey();
            if (keyInfo.KeyChar == 'J' || keyInfo.KeyChar == 'j')
            {
                Console.Clear();
                Console.WriteLine("Tidligere tilmeldte elever:");
                foreach (var student in students)
                {
                    Console.WriteLine($"{student.PersonalInfo.FirstName} {student.PersonalInfo.LastName} {student.Age} år gammel er tilmeldt {student.Courses[0].Name}");
                }
            }
            else if (keyInfo.KeyChar == 'N' || keyInfo.KeyChar == 'n')
            {
                break;
            }
            else
            {
                Console.WriteLine("\nForkert input. Vælg 'J' eller 'N'.");
            }
        } while (keyInfo.Key != ConsoleKey.J && keyInfo.Key != ConsoleKey.N);

        if (keyInfo.KeyChar == 'N')
        {
            break;
        }
    }
    else
    {
        Console.WriteLine("Ugyldig fødselsdato.");
    }
}

// Vis lærerinformation
Teacher teacher = new Teacher("Niels", "Olesen", new DateTime(1971, 2, 23), "CIT");
string teacherInfo = teacher.GetInfo(enrollments);
Console.WriteLine(teacherInfo);
        

        static Course SelectCourse(List<Course> courses)
{
    Console.WriteLine("Vælg et fag:");

    for (int i = 0; i < courses.Count; i++)
    {
        Console.WriteLine($"Fag id: {i + 1}, Fag navn: {courses[i].Name}");
    }

    Console.Write("Angiv ID for det fag elev skal tilmeldes: ");
    int courseId;
    if (int.TryParse(Console.ReadLine(), out courseId))
    {
        switch (courseId)
        {
            case 1:
                return courses[0]; // Grundlæggende Programmering
            case 2:
                return courses[1]; // Objektorienteret Programmering
            case 3:
                return courses[2]; // Studieteknik
            case 4:
                return courses[3]; // Netværk
            case 5:
                return courses[4]; // Clientside Programmering
            case 6:
                return courses[5]; // Database Programmering
            case 7:
                return courses[6]; // Computerteknologi
            default:
                return null; // Ugyldigt valg
        }
    }

    return null; // Ugyldigt input
}
    



