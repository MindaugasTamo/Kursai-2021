using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_OOP_Uzduotys.Models
{
    public class Zaidejas
    {
        public Zaidejas(string vardas, string pavarde)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            KortosRankoje = new List<Korta>();
            TaskuSkaicius = 0;
        }

        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public List<Korta> KortosRankoje { get; set; }
        public int TaskuSkaicius { get; set; }
    }
}
