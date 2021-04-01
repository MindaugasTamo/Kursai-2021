using P4_OOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_OOP.Extentions
{
    public static class HumanExtentions
    {
        private static List<Hobby> hobbies = new List<Hobby>
        {
            new Hobby{ HobbyId = 0, Text = "Photograpy", TextLt = "Fotografija" },
            new Hobby{ HobbyId = 1, Text = "Astrology", TextLt = "Astrologija" },
            new Hobby{ HobbyId = 2, Text = "Art", TextLt = "Animacija" },
            new Hobby{ HobbyId = 3, Text = "Blogging", TextLt = "Tinklaraščių rašymas" },
            new Hobby{ HobbyId = 4, Text = "Board games", TextLt = "Stalo žaidimai" },
            new Hobby{ HobbyId = 5, Text = "Book reading", TextLt = "Knygų skaitymas" },
            new Hobby{ HobbyId = 6, Text = "Card games", TextLt = "Kortų žaidimai" },
            new Hobby{ HobbyId = 7, Text = "Chess", TextLt = "Šachmatai" },
        };

        public static void RandomGenerateHoobies(this Human input)
        {
            const int minHobbies = 1;
            const int maxHobbies = 3;
            var rand = new Random();
            var numberOfHobbies = rand.Next(minHobbies, maxHobbies + 1);
            Hobby[] result = new Hobby[numberOfHobbies];


            for (int i = 0; i < numberOfHobbies; i++)
            {
                var hobbyId = -1;
                while (hobbyId == -1 || result.Contain(hobbyId))
                {
                    hobbyId = rand.Next(0, hobbies.Count);
                }
                result[i] = hobbies[hobbyId];
            }
            input.Hobbies = result.ToList();

        }

        private static bool Contain(this IEnumerable<Hobby> list, int id)
        {
            foreach (var item in list)
            {
                if (item != null && item.HobbyId == id) return true;
            }
            return false;
        }

    }
}
