using System;
using System.Collections.Generic;
using System.Text;

namespace E04.SpaceStation.Models.Astronauts.Models
{
    public class Biologist : Astronaut
    {
        public Biologist(string name)
            : base(name, 70)
        {
        }
        public override void Breath()
        {
            this.IfOxygenIsNull(5);
        }
    }
}
