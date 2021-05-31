using E11.StorageMaster.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace E11.StorageMaster.Models.Storages
{
    public class Warehouse : Storage
    {
        private const int DefaultCapacityValue = 10;
        private const int DefaultGarageSlots = 10;

        private static readonly Vehicle[] DefaultVehicles =
        {
            new Semi(),
            new Semi(),
            new Semi()
        };

        public Warehouse(string name)
            : base(name, DefaultCapacityValue, DefaultGarageSlots, DefaultVehicles)
        {
        }
    }
}
