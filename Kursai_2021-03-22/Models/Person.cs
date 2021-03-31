using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursai_2021_03_22.Models
{
    public class Person
    {
        public Person(string vardas, string pavarde, int amzius)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Amzius = amzius;
        }
        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }
        public int Amzius { get; private set; }
        public void VardasPavardeAmzius()
        {
            Console.WriteLine($"{Vardas} {Pavarde}, {Amzius}.");
        }
        public void Paseno()
        {
            Amzius += 1;
        }
    }
}
