using System;
using System.Collections.Generic;
using System.Text;

namespace _06.SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public bool Drive(double distanceTravelled)
        {
            double neededFuel = distanceTravelled * FuelConsumptionPerKilometer;

            if (neededFuel > FuelAmount)
            {
                return false;
            }

            TravelledDistance += distanceTravelled;
            FuelAmount -= neededFuel;

            return true;
        }
    }
}
