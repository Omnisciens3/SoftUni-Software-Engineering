using E04.SpaceStation.Models.Astronauts.Contracts;
using E04.SpaceStation.Models.Planets;
using System;
using System.Collections.Generic;
using System.Text;

namespace E04.SpaceStation.Models.Mission
{
    public interface IMission
    {
        void Explore(IPlanet planet, ICollection<IAstronaut> astronauts);
    }
}
