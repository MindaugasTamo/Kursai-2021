using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_OOP.Models
{
    public class Zmogus
    {
        public Zmogus(string vardas, string pavarde)
        {
            Vardas = vardas;
            Pavarde = pavarde;
        }

        public string Vardas { get; set; }
        public string Pavarde { get; set; }

        public virtual void Info() => Console.WriteLine($"{Vardas} {Pavarde}");

    }
}
