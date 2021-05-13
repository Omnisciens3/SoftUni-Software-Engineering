using System;
using System.Collections.Generic;
using System.Text;

namespace E06.SantaWorkshop.Core.Contracts
{
    public interface IController
    {
        string AddDwarf(string dwarfType, string dwarfName);

        string AddInstrumentToDwarf(string dwarfName, int power);

        string AddPresent(string presentName, int energyRequired);

        string CraftPresent(string presentName);

        string Report();
    }
}
