using System;
using System.Collections.Generic;
using System.Text;

namespace E04.SpaceStation.Models.Astronauts.Models
{
    public class Meteorologist : Astronaut
    {
        public Meteorologist(string name)
            : base(name, 90)
        {
        }
    }
}
