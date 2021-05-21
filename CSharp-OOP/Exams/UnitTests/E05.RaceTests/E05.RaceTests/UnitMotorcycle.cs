using System;
using System.Collections.Generic;
using System.Text;

namespace E05.RaceTests
{
    public class UnitMotorcycle
    {
        public UnitMotorcycle(string model, int horsePower, double cubicCentimeters)
        {
            this.Model = model;
            this.HorsePower = horsePower;
            this.CubicCentimeters = cubicCentimeters;
        }

        public string Model { get; }

        public int HorsePower { get; }

        public double CubicCentimeters { get; }
    }
}
