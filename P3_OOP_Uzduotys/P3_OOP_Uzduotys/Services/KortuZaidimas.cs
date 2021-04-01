using P3_OOP_Uzduotys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_OOP_Uzduotys.Services
{
    public class KortuZaidimas : IKortuZaidimas
    {
        public KortuZaidimas(List<Zaidejas> zaidejai)
        {
            Zaidejai = zaidejai;
        }

        public List<Zaidejas> Zaidejai { get; set; }
        public KortuKalade52Kortos Kalade { get; set; }
        public void Zaisti()
        {
            var galimiKortuTipai = new GalimiKortuTipai();
            Kalade = new KortuKalade52Kortos(galimiKortuTipai);
            Kalade.SumaisytiKortas();
            DalintiKortas();
        }

        public string RastiLaimetoja()
        {
            SuskaiciuotiTaskus();
            //TODO pabaigti
            throw new NotImplementedException();
        }



        private void DalintiKortas()
        {
            while (true)
            {
                foreach (var zaidejas in Zaidejai)
                {
                    zaidejas.KortosRankoje.Add(Kalade.PaimtiKorta());
                    //zaidejas.KortosRankoje.Add(Kalade.Kortos[0]);
                    //Kalade.Kortos.RemoveAt(0);
                    if (Kalade.Kortos.Count == 0) return;
                }
            }

        }

        private void SuskaiciuotiTaskus()
        {
            Dictionary<EKortosRusis, int> strategy = new Dictionary<EKortosRusis, int>
            {
                { EKortosRusis.Sirdys, 10 },
                { EKortosRusis.Bugnai, 5 },
                { EKortosRusis.Pikai, 2 },
                { EKortosRusis.Kryziai, -8 },

            };

            foreach (var zaidejas in Zaidejai)
            {
                foreach (var korta in zaidejas.KortosRankoje)
                {
                    zaidejas.TaskuSkaicius += korta.Tipas.AkiuSkaicius + strategy[korta.Rusis];
                }
            }
        }


    }
}
