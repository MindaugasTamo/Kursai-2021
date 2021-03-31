using P3_OOP.Enums;
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
    public class ArtificialLifeFactory : IRaceFactory
    {
        public RaceBase Build(RaceDto race)
        {
            if (race.Gender == (int)EArtificialLifeGender.ROBOT)
            {
                return new Robot(race.Id, race.FirstName, race.LastName);
            }
            else
            {
                return new Artificial(race.Id, race.FirstName, race.Gender);
            }
        }
    }
}
