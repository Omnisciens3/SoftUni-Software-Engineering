using System;
using System.Collections.Generic;
using System.Text;

namespace E11.StorageMaster.Models.Vehicles
{
    public class Semi : Vehicle
    {
        private const int DefaultCapacityValue = 10;

        public Semi()
            : base(DefaultCapacityValue)
        {
        }
    }
}
