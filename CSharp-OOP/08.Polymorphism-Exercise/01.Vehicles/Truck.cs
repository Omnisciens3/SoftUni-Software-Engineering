using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles
{
    public class Truck : Vehicle
    {
        private const double TruckAirConditionerModifier = 1.6;

        public Truck(double fuel, double fuelConsumption, double tankCapacity)
            :base(fuel, fuelConsumption, tankCapacity, TruckAirConditionerModifier)
        {
        }

        public override void Refuel(double litres)
        {
            if (litres <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (Fuel + litres > TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {litres} fuel in the tank");
            }

            Fuel += litres * 0.95;
        }
    }
}
