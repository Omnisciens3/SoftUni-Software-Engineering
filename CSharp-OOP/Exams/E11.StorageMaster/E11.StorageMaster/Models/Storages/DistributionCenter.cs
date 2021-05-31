using E11.StorageMaster.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace E11.StorageMaster.Models.Storages
{
    public class DistributionCenter : Storage
    {
        private const int DefaultCapacityValue = 2;
        private const int DefaultGarageSlots = 5;

        private static readonly Vehicle[] DefaultVehicles =
        {
            new Van(),
            new Van(),
            new Van()
        };

        public DistributionCenter(string name)
            : base(name, DefaultCapacityValue, DefaultGarageSlots, DefaultVehicles)
        {
        }
    }
}
