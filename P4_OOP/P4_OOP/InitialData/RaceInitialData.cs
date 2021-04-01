using P4_OOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_OOP.InitialData
{
    public static class RaceInitialData
    {
        public static List<RaceDto> DataSeed => new List<RaceDto>
        {
             new RaceDto(1, "Blane",   "Thompson",  1, "Human" ),
             new RaceDto(2, "Jesse",   "Lyons",     1, "Human" ),
             new RaceDto(1, "Bryn",    "Barton",    0, "Kree" ),
             new RaceDto(2, "Arielle", "Cullen",    1, "Kree" ),
             new RaceDto(1, "Vision",  "",          0, "Artificial" ),
             new RaceDto(2, "Ultron",  "",          0, "Artificial" ),
             new RaceDto(3, "Data",    "",          2, "Artificial" ),
             new RaceDto(4, "Giskard", "Reventlov", 2, "Artificial" ),
        };
    }
}
