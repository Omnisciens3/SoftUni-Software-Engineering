using System;
using System.Collections.Generic;
using System.Text;

namespace E01.MortalEngines.Entities.Contracts
{
    public interface IFighter : IMachine
    {
        bool AggressiveMode { get; }

        void ToggleAggressiveMode();
    }
}
