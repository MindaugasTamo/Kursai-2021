using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_OOP.Models
{
    public class RaceDto
    {
        public RaceDto(int id, string firstName, string lastName, int gender, string raceDiscriminator)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            RaceDiscriminator = raceDiscriminator;
        }

        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int Gender { get; }
        public string RaceDiscriminator { get; }
    }
}
