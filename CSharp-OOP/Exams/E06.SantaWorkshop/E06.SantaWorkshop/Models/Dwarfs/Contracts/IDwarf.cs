using E06.SantaWorkshop.Models.Instruments.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E06.SantaWorkshop.Models.Dwarfs.Contracts
{
    public interface IDwarf
    {
        string Name { get; }

        int Energy { get; }

        ICollection<IInstrument> Instruments { get; }

        abstract void Work();

        void AddInstrument(IInstrument instrument);
    }
}
