using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles
{
    public class Bus : Vehicle
    {
        private const double BusAirConditionerModifier = 1.4;

        public Bus(double fuel, double fuelConsumption, double tankCapacity)
            : base(fuel, fuelConsumption, tankCapacity, BusAirConditionerModifier)
        {
        }

        public void DriveEmpty(double distance)
        {
            double requiredFuel = FuelConsumption * distance;

            if (requiredFuel > Fuel)
            {
                throw new InvalidOperationException($"{GetType().Name} needs refueling");
            }

            Fuel -= requiredFuel;
        }
    }
}
