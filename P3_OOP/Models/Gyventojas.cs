using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_OOP.Models
{
    public class Gyventojas : Pilietis
    {
        public Gyventojas(
            string vardas,
            string pavarde,
            string asmensKodas,
            string pilietybe,
            string gyvenamojiVieta) : base(vardas, pavarde, asmensKodas, pilietybe)
        {
            GyvenamojiVieta = gyvenamojiVieta;
        }

        public string GyvenamojiVieta { get; set; }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"gyvena {GyvenamojiVieta}");
        }
    }
}
