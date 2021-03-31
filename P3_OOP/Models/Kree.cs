using P3_OOP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_OOP.Models
{
    public class Kree : Humanoid
    {
        public Kree(int id, string firstName, string lastName, EHumanoidGender gender) : base(id, firstName, lastName)
        {
            Gender = (int)gender;
        }
        public Kree(int id, string firstName, string lastName, int gender) : base(id, firstName, lastName)
        {
            Gender = gender;
        }
        public override int Gender { get; }
        public override string RaceDiscriminator => RaceClassificators.KREE;
    }
}
