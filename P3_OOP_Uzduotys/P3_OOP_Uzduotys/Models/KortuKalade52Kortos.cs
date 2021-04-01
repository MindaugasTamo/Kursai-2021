using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_OOP_Uzduotys.Models
{
    public class KortuKalade52Kortos
    {
        private readonly GalimiKortuTipai _galimiKortuTipai;
        public KortuKalade52Kortos(GalimiKortuTipai galimiKortuTipai)
        {
            _galimiKortuTipai = galimiKortuTipai;
            Kortos = new List<Korta>();
            UzpildytiKalade(); //kazkokia logika kuri užpildo lista Kortos
        }

        public List<Korta> Kortos { get; set; }

        public void SumaisytiKortas()
        {
            var sumaisytaKalade = new List<Korta>();
            var rnd = new Random();
            while (Kortos.Count > 0)
            {
                var atsitiktineKorta = rnd.Next(0, Kortos.Count);
                sumaisytaKalade.Add(Kortos[atsitiktineKorta]);
                Kortos.RemoveAt(atsitiktineKorta);
            }
            Kortos = sumaisytaKalade;
        }

        public Korta PaimtiKorta()
        {
            var korta = Kortos[0];
            Kortos.RemoveAt(0);
            return korta;
        }


        private void UzpildytiKalade()
        {
            foreach (var tipas in _galimiKortuTipai.Kortos52)
            {
                foreach (var rusis in Enum.GetValues(typeof(EKortosRusis)))
                {
                    Kortos.Add(new Korta((EKortosRusis)rusis, tipas));
                }
            }
        }


    }
}
