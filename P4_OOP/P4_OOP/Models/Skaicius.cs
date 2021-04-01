using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_OOP.Models
{
    public class Skaicius : IMatematika
    {
        public Skaicius(int reiksme)
        {
            Reiksme = reiksme;
        }

        public int Reiksme { get; }

        public int Atimti(int skaicius) => Reiksme - skaicius;
        public int Prideti(int skaicius) => Reiksme + skaicius;
        public int Padauginti(int skaicius) => Reiksme * skaicius;
        public double Padalint(int skaicius) => (double)Reiksme / skaicius;

        public double PakeltiKvadratu() => Math.Pow(Reiksme, 2);
        public double PakeltiKubu() => Math.Pow(Reiksme, 3);
    }
}
