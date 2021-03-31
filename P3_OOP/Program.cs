using P3_OOP.Models;
using P3_OOP.Services;
using System;

namespace P3_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterFactory factory = new CharacterFactory();
            var visiVekejai = factory.BildAll();
            foreach (var person in visiVekejai)
            {
                Console.WriteLine($"{person.FullName} is a {person.RaceDiscriminator} {person.Gender} {person.GetType()} ");
            }

            /*
            2. Matematika
            - Sukurkite klasę Skaicius . Savyje turi tik readonly kintamąjį kuriame saugoma reikšmė sveikasis skaičius.
            - Sukurkite interfeisą IMatematika . 
            - Interfeise aprašykite metodus: 
                Pridėti, Atimti, Padauginti, Padalinti --> metodams bus paduodamas sveikasis skaičius ir bus grąžinama reikšmė,
                PakeltiKvadratu , PakeltiKubu --> metodai grąžina reikšmes.
            - Klasė Skaicius paveldi interfeisą . 
            - Implementuokite paveldėtus metodus.
            3. Geometrija
            - Sukurti klasę Figura , kuri saugo pavadinimą readonly propertyje
            - Sukurti interfeisą IGeometrija , kurioje aprašyti du metodai Plotas ir Perimetras. Abu grąžina double reikšmes.
            - Sukurti klases: Kvadratas, Staciakampis , Statusis Trikampis ir Apskritimas 
                (klasėse susikurti reikiamus properčius fieldus visi jie turi būti readonly ). 
            - Kiekviena klasė paveldi klasę Figura ir interfeisą IGeometrija.
            - Realizuoti klases.
             */

            Console.WriteLine("----------------------");
            IMatematika skaicius = new Skaicius(2);
            Console.WriteLine(skaicius.PakeltiKvadratu());


            Console.WriteLine();
            Console.WriteLine("-End of program. Press any key-");
            Console.ReadKey();
        }
    }
}
