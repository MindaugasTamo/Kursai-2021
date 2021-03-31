using P3_OOP.Enums;
using P3_OOP.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_OOP.Models
{
    public class Robot : RaceBase
    {
        public Robot(int id, string firstName) : base(id, firstName)
        {
        }

        public Robot(int id, string firstName, string lastName) : this(id, firstName)
        {
            LastName = lastName;
        }

        public string LastName { get; set; }
        public override string RaceDiscriminator => RaceClassificators.ARTIFICIAL;
        public override int Gender => (int)EArtificialLifeGender.ROBOT;

        public override string FullName
        {
            get
            {
                return string.IsNullOrWhiteSpace(LastName) ? $"R. {FirstName}" : $"R. {FirstName} {LastName}";
            }

        }
    }
}
