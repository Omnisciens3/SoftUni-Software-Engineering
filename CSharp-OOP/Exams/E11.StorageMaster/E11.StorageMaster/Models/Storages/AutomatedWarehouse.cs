using E11.StorageMaster.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace E11.StorageMaster.Models.Storages
{
    public class AutomatedWarehouse : Storage
    {
        private const int DefaultCapacityValue = 1;
        private const int DefaultGarageSlots = 2;

        private static readonly Vehicle[] DefaultVehicles =
        {
            new Truck()
        };

        public AutomatedWarehouse(string name)
            : base(name, DefaultCapacityValue, DefaultGarageSlots, DefaultVehicles)
        {
        }
    }
}
