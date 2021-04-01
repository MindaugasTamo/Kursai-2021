using P4_OOP.Enums;
using P4_OOP.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_OOP.Models
{
    public class Artificial : RaceBase
    {
        public Artificial(int id, string firstName, EArtificialLifeGender gender) : base(id, firstName)
        {
            Gender = gender != EArtificialLifeGender.ROBOT ? (int)gender : 0;
        }
        public Artificial(int id, string firstName, int gender) : base(id, firstName)
        {
            Gender = gender != 2 ? gender : 0;
        }
        public override string RaceDiscriminator => RaceClassificators.ARTIFICIAL;

        public override int Gender { get; }

        public override string FullName => FirstName;
    }
}
