using P4_OOP.Enums;
using P4_OOP.Extentions;
using P4_OOP.Models;
using System;
using System.Collections.Generic;

namespace P4_OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Human> people = new List<Human>
            {
                new Human(1, "Petras", "Petraitis", (int)EHumanoidGender.MALE),
                new Human(1, "Jonas", "Jonaitis", (int)EHumanoidGender.MALE),
                new Human(1, "Antanas", "Antanaitis", (int)EHumanoidGender.MALE),
                new Human(1, "Agne", "Agnaite", (int)EHumanoidGender.FEMALE),
                new Human(1, "Renata", "Renataite", (int)EHumanoidGender.FEMALE),
            };

            foreach (var human in people)
            {
                human.RandomGenerateHoobies();
                Console.WriteLine($"{human.FullName} turi hobius:");
                foreach (var hobby in human.Hobbies)
                {
                    Console.Write($" {hobby.TextLt}, ");
                }
                Console.WriteLine();
            }

            /*
           1. Sukurkite statinę klasę General, kurioje būtų metodai:
              NuskaitytiSveikajiSkaiciu , NuskaitytiDoubleSkaiciu , PrintIntArray
           2. Sukurti abstrakčią klasę TrasportoPriemone . 
          Savyje ji turi Pavadinimą, VidutiniGreiti . 
          Kintamieji inicializuojami per konstruktorių. Turi abstraktų metodą Vaziuoti .
          Sukurti klases Dviratis ir Automobilis.
          Realizuoti metodą Važiuoti metodas turi sugeneruoti kelionę, kokį atstumą nuvažiavo, 
          kiek laiko važiavo, kiek buvo padaryta sustojimų. Generuoti duomenis atsižvelgiant į transporto priemonę. 
           3.
           Suprogramuoti kortų žaidimą Black Jack. Arba kitaip 21.
           Žaidžia žmogus prieš kompiuterį. Gali žaisti ir keli žaidėjai max 7.
           */

        }
    }
}
