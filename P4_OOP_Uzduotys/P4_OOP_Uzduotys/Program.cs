using System;

namespace P4_OOP_Uzduotys
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportoPriemone dviratis1 = new Dviratis("Akula", 17.0);

            dviratis1 = TransportoPriemone.Vaziuoti(3, 6);
        }
    }
}
