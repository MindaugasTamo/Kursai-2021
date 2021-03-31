using System;
using Kursai_2021_03_22.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursai_2021_03_22.Models
{
    public class Human
    {
        private string _firstName;
        private string _lastName;

        public Human(int id, string firstName, string lastName, EHumanoidGender gender)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Hobbies = new List<Hobby>();
        }
        public Human(int id, string firstName, string lastName, EHumanoidGender gender, DateTime? birthDate) : this(id, firstName, lastName, gender)
        {
            BirthDate = birthDate;
        }

        public int Id { get; set; }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(_firstName))
                {
                    NameChanges += $"{_firstName} -> {value} {Environment.NewLine}";
                }
                _firstName = value;
            }
        }
        public string LastName
        {
            get => _lastName;
            set
            {
                if (!string.IsNullOrWhiteSpace(_lastName))
                {
                    NameChanges += $"{_lastName} -> {value} {Environment.NewLine}";
                }
                _lastName = value;
            }
        }
        public EHumanoidGender Gender { get; set; }
        public DateTime? BirthDate { get; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string NameChanges { get; protected set; }
        public int? Age => GetAge();

        //kompozicija  1:1
        public Profession Profession { get; set; }
        
        //kompozicija 1:many
        public List<Hobby> Hobbies { get; set; }



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
