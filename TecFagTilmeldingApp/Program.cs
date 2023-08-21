// See https://aka.ms/new-console-template for more information
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


Teacher niels = new("Niels", "Olesen", new DateTime(1971, 2, 23), "CIT");
PersonModel nielspersonalInfo = niels.PersonalInfo;
Student patrik = new("Patrik", "Nielsen", new DateTime(1996, 8, 1));
PersonModel patrikpersonalInfo = patrik.PersonalInfo;
Course course = new("OOP", nielspersonalInfo);

Console.WriteLine($"{course.Name} Teacher: {nielspersonalInfo.FirstName} {nielspersonalInfo.LastName}");

Console.WriteLine(nielspersonalInfo.FirstName + " alder: " + niels.Age);

Console.WriteLine(patrikpersonalInfo.FirstName + " alder: " + patrik.Age);

Console.WriteLine($"{course.Name} lærer er: {nielspersonalInfo.FirstName} {nielspersonalInfo.LastName}");
