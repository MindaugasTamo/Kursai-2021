using System;

namespace Kursai_2021_03_22
{
    class Program
    {
        static void Main(string[] args)
        {
            var hobby1 = new Hobby();
            hobby1.HobbyId = 1;
            hobby1.Text = "Astrology";
            hobby1.TextLt = "Astrologija";

            var hobby2 = new Hobby(2, "Art", "Menas");

            var hobby3 = new Hobby { HobbyId = 3, Text = "Animation", TextLt = "Animacija" };

            var profession1 = new Profession();

            Console.WriteLine();
            Console.WriteLine("------- Press any key to continue -------");
            Console.ReadKey();
        }
    }
}
