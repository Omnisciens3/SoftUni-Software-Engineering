using System;
using System.Collections.Generic;
using System.Text;

namespace _05.MilitaryElite
{
    public interface IRepair
    {
        string PartName { get; }

        int HoursWorked { get; }

    }
}
