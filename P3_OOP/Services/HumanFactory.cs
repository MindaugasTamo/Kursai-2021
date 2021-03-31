using P3_OOP.Models;
using P3_OOP.Models.Abstract;
using P3_OOP.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_OOP.Services
{
    public class HumanFactory : IRaceFactory
    {
        public RaceBase Build(RaceDto race)
        {
            return new Human(race.Id, race.FirstName, race.LastName, race.Gender);
        }
    }
}
