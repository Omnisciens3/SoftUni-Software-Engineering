using System;
using System.Collections.Generic;
using System.Text;

namespace E03.BlueOrgin.Tests
{
    public class Astronaut
    {
        public Astronaut(string name, double oxygenInPercentage)
        {
            this.Name = name;
            this.OxygenInPercentage = oxygenInPercentage;
        }

        public string Name { get; }

        public double OxygenInPercentage { get; }
    }
}
