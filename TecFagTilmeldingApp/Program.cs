//Dette er min branch for øvelser.


using System.Reflection.Emit;
using TecFagTilmeldingApp.Animals;
using TecFagTilmeldingApp.Codes;
using TecFagTilmeldingApp.Models;
using TecFagTilmeldingApp.Personer;
using TecFagTilmeldingApp.WordCount;
using TecFagTilmeldingApp.MySounds;
using System.Media;



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


//while (true)
//{
//    Console.Write("Indtast tallet 1 for at afspille lyden: ");
//    string talInput = Console.ReadLine();

//    if (talInput == "1")
//    {
//        string myCurrentDir = System.IO.Directory.GetCurrentDirectory();
//        string appDir = System.IO.Path.Combine(myCurrentDir, @"MySounds\minlyd.wav");

//        System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
//        soundPlayer.SoundLocation = appDir;
//        soundPlayer.Play();
//    }

//    else
//    {
//        Console.Clear();
//    }
//}
Console.WriteLine("Velkommen til mit alverdens øvelser program!\n");
Console.WriteLine("Tryk vilkårgelig tast for at starte programmet");
Console.ReadKey();

MainLyd lyd = new MainLyd();



while (true)
{
    Console.Clear();
    Console.WriteLine("Dette er hovedmenuen");
    Console.WriteLine("1. WordCounter");
    Console.WriteLine("2. Animal Sounds");
    Console.WriteLine("3. Elev/Lærer");
    Console.WriteLine("4. Teacher/Student");
    Console.WriteLine("5. Afslut");


    lyd.MainAfspiller();
    string choice = Console.ReadLine();



    switch (choice)
    {
        case "1":
            WordCounterMenu();
            break;

        case "2":
            AnimalSoundsMenu();
            break;

        case "3":
            ElevLærerMenu();
            break;

        case "4":
            TeacherStudentMenu();
            break;

        case "5":
            return;

        default:
            Console.Clear();
            Console.WriteLine("Ugyldigt valg. Prøv igen.");
            break;
    }
}


static void WordCounterMenu()
{

    string text = "It's important to understand two fundamental points about the type system in .NET:\r\n\r\nIt supports the principle of inheritance. Types can derive from other types, called base types. The derived type inherits (with some restrictions) the methods, properties, and other members of the base type. The base type can in turn derive from some other type, in which case the derived type inherits the members of both base types in its inheritance hierarchy. All types, including built-in numeric types such as System.Int32 (C# keyword: int), derive ultimately from a single base type, which is System.Object (C# keyword: object). This unified type hierarchy is called the Common Type System (CTS). For more information about inheritance in C#, see Inheritance.\r\nEach type in the CTS is defined as either a value type or a reference type. These types include all custom types in the .NET class library and also your own user-defined types. Types that you define by using the struct keyword are value types; all the built-in numeric types are structs. Types that you define by using the class or record keyword are reference types. Reference types and value types have different compile-time rules, and different run-time behavior.\r\nThe following illustration shows the relationship between value types and reference types in the CTS.";

    int wordCount = WordCounter.Count(text);

    Console.WriteLine($"Antal forekomster af 'type' eller 'types': {wordCount}");

    Console.ReadLine();
}



static void AnimalSoundsMenu()
{
    Animals animal = null;

    while (true)
    {
        Console.Clear();
        Console.WriteLine("Animal Sounds Menu:\n");
        Console.WriteLine("Choose an animal:");
        Console.WriteLine("1. Dog");
        Console.WriteLine("2. Cat");
        Console.WriteLine("3. Tilbage til hovedmenu");

        string choice = Console.ReadLine();



        switch (choice)
        {
            case "1":
                Console.Clear();
                animal = new Dog();
                break;

            case "2":
                Console.Clear();
                animal = new Cat();
                break;

            case "3":
                return;

            default:
                Console.Clear();
                Console.WriteLine("Ugyldigt valg. Prøv igen.");
                break;
        }

        if (animal != null)
        {
            animal.MakeSound();
            Console.Clear();
        }

    }

}


static void ElevLærerMenu()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Elev/Lærer Menu:");
        Console.WriteLine("1. Elev");
        Console.WriteLine("2. Lærer");
        Console.WriteLine("3. Tilbage til hovedmenu");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Clear();
                Elev elev = new Elev("Patrik", "Nielsen", new DateTime(1996, 8, 1));
                elev.Greet();
                Console.WriteLine(elev.ShowMyIdentity());
                Console.ReadLine();
                break;

            case "2":
                Console.Clear();
                Lærer lærer = new Lærer("Niels", "Olesen", new DateTime(1971, 2, 23));
                lærer.Greet();
                Console.WriteLine(lærer.ShowMyIdentity());
                Console.ReadLine();
                break;

            case "3":
                return;

            default:
                Console.Clear();
                Console.WriteLine("Ugyldigt valg. Prøv igen.");
                break;
        }
    }
}



static void TeacherStudentMenu()
{
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
}



