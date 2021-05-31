using System;
using System.Collections.Generic;
using System.Text;

namespace E11.StorageMaster.Models.Vehicles
{
    public class Van : Vehicle
    {
        private const int DefaultCapacityValue = 2;

        public Van()
            : base(DefaultCapacityValue)
        {
        }
    }
}
