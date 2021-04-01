using P4_OOP.InitialData;
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
    public class CharacterFactory
    {
        public IEnumerable<RaceBase> BildAll()
        {
            foreach (var race in RaceInitialData.DataSeed)
            {
                yield return Build(race);
            }
        }

        protected RaceBase Build(RaceDto race)
        {
            Dictionary<string, IRaceFactory> strategy = new Dictionary<string, IRaceFactory>
            {
                { RaceClassificators.HUMAN, new HumanFactory() },
                { RaceClassificators.KREE, new KreeFactory() },
                { RaceClassificators.ARTIFICIAL, new ArtificialLifeFactory() },
            };
            var character = strategy[race.RaceDiscriminator].Build(race);
            return character;
        }

    }
}
