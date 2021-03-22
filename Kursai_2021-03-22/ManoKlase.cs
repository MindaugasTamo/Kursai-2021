using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursai_2021_03_22
{
    class ManoKlase //inicializavimas - klases sukurimas
    {
        public ManoKlase( int a)
        {
            MyProperty = a;
            //daro kazkokia logika
        }
        public int MyProperty { get; private set; }
        public string Tekstas { get; set; }

        int a = 5;
        
        public void Metodas(string vardas)
        {
            Console.WriteLine($"Labas {vardas}");
        }
    }
}
