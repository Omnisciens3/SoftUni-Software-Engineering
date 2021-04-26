using System;
using System.Collections.Generic;
using System.Text;

namespace E01.MortalEngines.Entities.Contracts
{
    public interface IPilot
    {
        string Name { get; }

        void AddMachine(IMachine machine);

        string Report();
    }
}
