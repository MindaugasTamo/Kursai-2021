using P4_OOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_OOP.Services
{
    public class ProfessionFactory
    {
        public Profession BuildEngineer()
        {
            return new Profession(2, "Engineer", "Inzinierius");
        }
        public Profession BuildPharmacist()
        {
            return new Profession(2, "Pahrmacist", "Vaistininkas");
        }
    }
}
