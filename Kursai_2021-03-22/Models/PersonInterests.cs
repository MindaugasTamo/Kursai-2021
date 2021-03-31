using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursai_2021_03_22.Models
{
    class PersonInterests
    {
        const decimal hobbyPrice = 100;
        const int maxHobbyCount = 4;
        public PersonInterests(Person person)
        {
            Person = person;
        }

        public Person Person { get; }
        public List<Hobby> Hobbies { get; protected set; }
        public decimal HobbiesPrice => Hobbies.Count * hobbyPrice;
        public List<string> HobbiesLog { get; set; } = new List<string>();
        public void RemoveHobby(int hobbyId, string reason)
        {
            for (int i = 0; i < Hobbies.Count; i++)
            {
                if (Hobbies[i].HobbyId == hobbyId)
                {
                    HobbiesLog.Add($"Removed \"{Hobbies[i].Text}\", reason - {reason}");
                    Hobbies.RemoveAt(i);
                    return;
                }
            }
            Console.WriteLine($"Error removing hobby. Hobby with id {hobbyId} not found.");
        }
        public void AddHobby(Hobby hobby)
        {
            if (Hobbies.Count < maxHobbyCount)
            {
                Hobbies.Add(hobby);
            }
            else
            {
                Console.WriteLine($"Cannot add {hobby.Text}. Person has too many hobbies");
            }
        }
    }
}
