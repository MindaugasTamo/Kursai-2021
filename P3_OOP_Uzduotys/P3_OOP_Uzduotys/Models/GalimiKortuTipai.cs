using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_OOP_Uzduotys.Models
{
    public class GalimiKortuTipai
    {
        public virtual KortosTipas Dviake => new KortosTipas("Dviake", 2);
        public virtual KortosTipas Triake => new KortosTipas("Triake", 3);
        public virtual KortosTipas Keturake => new KortosTipas("Keturake", 4);
        public virtual KortosTipas Penkiake => new KortosTipas("Penkiake", 5);
        public virtual KortosTipas Sesiake => new KortosTipas("Sesiake", 6);
        public virtual KortosTipas Septynake => new KortosTipas("Septynake", 7);
        public virtual KortosTipas Astuonake => new KortosTipas("Astuonake", 8);
        public virtual KortosTipas Devynake => new KortosTipas("Devynake", 9);
        public virtual KortosTipas Desimake => new KortosTipas("Desimake", 10);
        public virtual KortosTipas Valetas => new KortosTipas("Valetas", 11);
        public virtual KortosTipas Dama => new KortosTipas("Dama", 12);
        public virtual KortosTipas Karalius => new KortosTipas("Karalius", 13);
        public virtual KortosTipas Tuzas => new KortosTipas("Tuzas", 14);


        public virtual List<KortosTipas> Kortos52 => new List<KortosTipas> { Dviake, Triake, Keturake, Penkiake, Sesiake, Septynake, Astuonake, Devynake, Desimake, Valetas, Dama, Karalius, Tuzas };

    }
}
