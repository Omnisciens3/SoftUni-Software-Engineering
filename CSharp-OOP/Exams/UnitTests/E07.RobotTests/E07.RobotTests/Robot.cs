using System;
using System.Collections.Generic;
using System.Text;

namespace E07.RobotTests
{
    public class Robot
    {
        public Robot(string name, int maximumBattery)
        {
            this.Name = name;
            this.MaximumBattery = maximumBattery;
            this.Battery = maximumBattery;
        }

        public string Name { get; set; }

        public int Battery { get; set; }

        public int MaximumBattery { get; }
    }
}
