using System;
using System.Collections.Generic;
using System.Text;

namespace E04.SpaceStation.Models.Planets
{
    public interface IPlanet
    {
        ICollection<string> Items { get; }

        string Name { get; }
    }
}
