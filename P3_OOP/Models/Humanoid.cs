using P3_OOP.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_OOP.Models
{
    public abstract class Humanoid : RaceBase
    {
        private string _firstName;
        private string _lastName;

        protected Humanoid(int id, string firstName, string lastName) : base(id, firstName)
        {
            LastName = lastName;
        }

        public override string FirstName
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

        public override string FullName => $"{FirstName} {LastName}";


        public string NameChanges { get; protected set; }

    }
}
