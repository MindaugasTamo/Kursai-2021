using System;
using Kursai_2021_03_22.Enums;
using Kursai_2021_03_22.Models;
using Kursai_2021_03_22.Services;

namespace Kursai_2021_03_22
{
    class Program
    {
        static void Main(string[] args)
        {
            var hobby1 = new Hobby();
            hobby1.HobbyId = 1;
            hobby1.Text = "Astrology";
            hobby1.TextLt = "Astrologija";

            var hobby2 = new Hobby(2, "Art", "Menas");

            var hobby3 = new Hobby { HobbyId = 3, Text = "Animation", TextLt = "Animacija" };

            var profession1 = new Profession(1);

            profession1.SetText("Kazkoks tekstas");

            var professionFactory = new ProfessionFactory();
            var profession2 = professionFactory.BuildEngineer();
            var profession3 = professionFactory.BuildPharmacist();

            /*
            Sukurkite enum HumanoidGender su reiksmemis 0 - MALE, 1 FEMALE
            */

            var human1 = new Human(1, "Vardenis", "Pavardenis", EHumanoidGender.MALE, new DateTime(2000, 1, 1));
            Console.WriteLine($"human1 = {human1.FullName}");
            human1.FirstName = "Belekas";
            human1.FirstName = "Kitas";
            Console.WriteLine($"human1 = {human1.FullName}");
            Console.WriteLine($"human1 vardu keitimas \n{human1.NameChanges}");
            Console.WriteLine($"human1 amzius {human1.Age}");

            //TARPINE UZDUOTIS 1.-----------------------
            Console.WriteLine("------------------------------------");
            var person = new Person("Petras", "Petraitis", 20);
            person.VardasPavardeAmzius();
            person.Paseno();
            person.VardasPavardeAmzius();
            Console.WriteLine("------------------------------------");
            //------------------------------------------

            human1.Profession = new Profession(2, "Programmer", "Programuotojas");

            human1.Hobbies.Add(new Hobby(1, "Art", "Menas"));
            human1.Hobbies.Add(new Hobby(2, "Astrology", "Astrologija"));

            //TARPINE UZDUOTIS 2.-----------------------
            Console.WriteLine("------------------------------------");
            PersonInterests personInterests = new PersonInterests(person);
            personInterests.AddHobby(new Hobby(1, "Art", "Menas"));
            personInterests.AddHobby(new Hobby(2, "Astrology", "Astrologija"));
            personInterests.AddHobby(new Hobby(3, "Animation", "Animacija"));
            personInterests.AddHobby(new Hobby(4, "Computer games", "Kompiuteriniai žaidimai"));
            personInterests.AddHobby(new Hobby(5, "Football", "Futbolas"));
            Console.WriteLine("---ADD---");
            Console.WriteLine($"Person {personInterests.Person.Vardas} has hobbies:");
            foreach (var hobby in personInterests.Hobbies)
            {
                Console.WriteLine($"{hobby.Text}");
            }
            Console.WriteLine("---REMOVE---");
            personInterests.RemoveHobby(2, "Not interesting");
            personInterests.RemoveHobby(4, "Bored");
            personInterests.RemoveHobby(5, "Too hard");
            foreach (var hobby in personInterests.Hobbies)
            {
                Console.WriteLine($"{hobby.Text}");
            }
            Console.WriteLine("--HobbiesLog--");
            foreach (var log in personInterests.HobbiesLog)
            {
                Console.WriteLine($"{log}");
            }
            //------------------------------------------

            Console.WriteLine();
            Console.WriteLine("------- Press any key to continue -------");
            Console.ReadKey();
        }
        
    }
}
