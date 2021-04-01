using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_OOP_Uzduotys
{
    class Dviratis : TransportoPriemone
    {
        public Dviratis(string pavadinimas, double vidutinisGreitis) : base(pavadinimas, vidutinisGreitis)
        {
        }
        public override void Vaziuoti(int kelionesLaikas, int sustojimai)
        {
            Console.WriteLine($"Su dviraciu {Pavadinimas} nuvaziavo {VidutinisGreitis * kelionesLaikas} ir sustojo {sustojimai}");
        }
    }
}
