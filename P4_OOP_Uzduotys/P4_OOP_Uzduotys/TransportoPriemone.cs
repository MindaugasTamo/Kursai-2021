using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_OOP_Uzduotys
{
    public abstract class TransportoPriemone
    {
        protected TransportoPriemone(string pavadinimas, double vidutinisGreitis)
        {
            Pavadinimas = pavadinimas;
            VidutinisGreitis = vidutinisGreitis;
        }

        public string Pavadinimas { get; set; }
        public double VidutinisGreitis { get; set; }
        public abstract void Vaziuoti(int kelionesLaikas, int sustojimai);
    }
}
