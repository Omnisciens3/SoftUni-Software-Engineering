using System;
using System.Collections.Generic;
using System.Text;

namespace _05.MilitaryElite
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
