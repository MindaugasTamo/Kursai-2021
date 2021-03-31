using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_OOP.Models
{
    public class Pilietis : Zmogus
    {
        public Pilietis(
            string vardas,
            string pavarde,
            string asmensKodas,
            string pilietybe) : base(vardas, pavarde)
        {
            AsmensKodas = asmensKodas;
            Pilietybe = pilietybe;
        }


        public string AsmensKodas { get; set; }
        public string Pilietybe { get; set; }

        public override void Info()
        {
            Console.WriteLine($"{Vardas} {Pavarde} {AsmensKodas} {Pilietybe}");
        }

    }
}
