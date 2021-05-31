using System;
using System.Collections.Generic;
using System.Text;

namespace E11.StorageMaster.Models.Vehicles
{
    public class Truck : Vehicle
    {
        private const int DefaultCapacityValue = 5;

        public Truck()
            : base(DefaultCapacityValue)
        {
        }
    }
}
