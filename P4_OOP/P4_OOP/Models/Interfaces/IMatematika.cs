using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_OOP.Models.Interfaces
{
    public interface IMatematika
    {
        int Prideti(int skaicius);
        int Atimti(int skaicius);
        int Padauginti(int skaicius);
        double Padalint(int skaicius);
        double PakeltiKvadratu();
        double PakeltiKubu();
    }
}
