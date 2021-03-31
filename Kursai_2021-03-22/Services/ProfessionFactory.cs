using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kursai_2021_03_22.Models;

namespace Kursai_2021_03_22.Services
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
