using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_OOP_Uzduotys.Models
{
    public class Korta
    {
        public Korta(EKortosRusis rusis, KortosTipas tipas)
        {
            Rusis = rusis;
            Tipas = tipas;
        }
        /// <summary>pikos, kryziai.....</summary>
        public EKortosRusis Rusis { get; }

        /// <summary>vienake, dviake ..... karalius ......</summary>
        public KortosTipas Tipas { get; }
    }
}
