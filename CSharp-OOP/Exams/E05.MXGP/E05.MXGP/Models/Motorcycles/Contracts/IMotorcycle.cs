using System;
using System.Collections.Generic;
using System.Text;

namespace E05.MXGP.Models.Motorcycles.Contracts
{
    public interface IMotorcycle
    {
        string Model { get; }

        int HorsePower { get; }

        double CubicCentimeters { get; }

        double CalculateRacePoints(int laps);
    }
}
