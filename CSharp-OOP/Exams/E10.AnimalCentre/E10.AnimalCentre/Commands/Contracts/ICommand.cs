using System;
using System.Collections.Generic;
using System.Text;

namespace E10.AnimalCentre.Commands.Contracts
{
    public interface ICommand
    {
        string Name { get; }

        string[] Arguments { get; }
    }
}
