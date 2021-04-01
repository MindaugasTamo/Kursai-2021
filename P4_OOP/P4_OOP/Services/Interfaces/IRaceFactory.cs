using P4_OOP.Models;
using P4_OOP.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_OOP.Services.Interfaces
{
    public interface IRaceFactory
    {
        RaceBase Build(RaceDto race);
    }
}
