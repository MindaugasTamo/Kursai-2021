using P3_OOP_Uzduotys.Models;
using P3_OOP_Uzduotys.Services;
using System;
using System.Collections.Generic;

namespace P3_OOP_Uzduotys
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ##### SAVARANKIŠKOS UŽDUOTYS #####
          ** UŽDUOTIS 3 **
          Suprogramuoti kortų kaladę. (52 kortų)
          ** UŽDUOTIS 4 **
          Suprogramuoti kortų žaidimą. Žaidžia 2 arba 4 žaidėjai. 
          Žaidėjams išdalinamos visos kortos. 
          Gavus kortas paskaičiuojama, kiek kiekvienas surinko taškų ir daugiausiai surinkęs laimi. 
          Taškai skaičiuojami taip (sumuojasi):
          - Nuo 2 iki 10 tiek kiek vertės turi visos kortos.
          - Galvos vertos po 10 taškų.
          - Kiek turi širdžių kortų x10.
          - Kiek turi būgnų kortų x5.
          - Kiek turi lapų kortų x2.
          - Kiek turi kryžių kortų minus x8.
         
           */

            var kortuTipas = new GalimiKortuTipai();
            var kalade = new KortuKalade52Kortos(kortuTipas);
            Console.WriteLine($"kortu kaladeje yra {kalade.Kortos.Count} kortos");

            //Console.WriteLine($"korta 3 yra {kalade.Kortos[3].Rusis} {kalade.Kortos[3].Tipas.Pavadinimas}");
            KortuZaidimas zaidimas = new KortuZaidimas(new List<Zaidejas> { new Zaidejas("Petras", "Petraitis"), new Zaidejas("Agne", "Agnaite") });
            zaidimas.Zaisti();



            Console.WriteLine("------------");
        }
    }
}
