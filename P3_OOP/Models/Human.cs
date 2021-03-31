using P3_OOP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_OOP.Models
{
    public class Human : Humanoid
    {


        public Human(int id, string firstName, string lastName, EHumanoidGender gender) : base(id, firstName, lastName)
        {
            Gender = (int)gender;
            Hobbies = new List<Hobby>();
        }
        public Human(int id, string firstName, string lastName, int gender) : base(id, firstName, lastName)
        {
            Gender = gender;
            Hobbies = new List<Hobby>();
        }


        public override int Gender { get; }

        public DateTime? BirthDate { get; }


        public int? Age => GetAge();

        //Kompozicija 1:1
        public Profession Profession { get; set; }

        //Kompozicija 1:M
        public List<Hobby> Hobbies { get; set; }

        public override string RaceDiscriminator => RaceClassificators.HUMAN;

        protected int? GetAge()
        {
            if (BirthDate == null)
            {
                return null;
            }
            var timeSpan = DateTime.Now.Subtract((DateTime)BirthDate);
            return new DateTime(timeSpan.Ticks).Year - 1;
        }


    }
}
