using System;
using System.Collections.Generic;
using System.Text;

namespace E06.SantaWorkshop.Models.Instruments.Contracts
{
    public interface IInstrument
    {
        int Power { get; }

        void Use();

        bool IsBroken();
    }
}
