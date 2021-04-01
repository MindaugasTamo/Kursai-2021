using System;

namespace P4_OOP_Uzduotys
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportoPriemone dviratis1 = new Dviratis("Akula", 17.0);
            TransportoPriemone auto1 = new Automobilis("Volvo", 100.0);
            dviratis1.Vaziuoti(3, 6);
            auto1.Vaziuoti(4, 2);
        }
    }
}
