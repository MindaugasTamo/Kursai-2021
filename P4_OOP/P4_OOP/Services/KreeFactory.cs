using P4_OOP.Models;
using P4_OOP.Models.Abstract;
using P4_OOP.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_OOP.Services
{
    public class KreeFactory : IRaceFactory
    {
        public RaceBase Build(RaceDto race)
        {
            return new Kree(race.Id, race.FirstName, race.LastName, race.Gender);
        }
    }
}
