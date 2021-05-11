using E04.SpaceStation.Models.Bags;
using System;
using System.Collections.Generic;
using System.Text;

namespace E04.SpaceStation.Models.Astronauts.Contracts
{
    public interface IAstronaut
    {
        string Name { get; }

        double Oxygen { get; }

        bool CanBreath { get; }

        IBag Bag { get; }

        void Breath();
    }
}
