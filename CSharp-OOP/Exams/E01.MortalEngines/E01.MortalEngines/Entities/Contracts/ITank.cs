using System;
using System.Collections.Generic;
using System.Text;

namespace E01.MortalEngines.Entities.Contracts
{
    public interface ITank : IMachine
    {
        bool DefenseMode { get; }

        void ToggleDefenseMode();
    }
}
