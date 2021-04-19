using System;
using System.Collections.Generic;
using System.Text;

namespace _05.MilitaryElite
{
    public interface IPrivate : ISoldier
    {
        decimal Salary { get; }
    }
}
