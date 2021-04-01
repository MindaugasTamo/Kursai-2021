using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_OOP_Uzduotys
{
    public class Automobilis : TransportoPriemone
    {
        public Automobilis(string pavadinimas, double vidutinisGreitis) : base(pavadinimas, vidutinisGreitis)
        {
        }
        public override void Vaziuoti(int kelionesLaikas, int sustojimai)
        {
            Console.WriteLine($"Su automobiliu {Pavadinimas} nuvaziavo {VidutinisGreitis * kelionesLaikas} km ir sustojo {sustojimai} kartus.");
        }
    }
}
