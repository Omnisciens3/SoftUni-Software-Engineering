﻿using System;
using System.Collections.Generic;
using System.Text;

namespace E11.StorageMaster.Models.Products
{
    public class SolidStateDrive : Product
    {
        private const double DefaultWeight = 0.2;

        public SolidStateDrive(double price)
            : base(price, DefaultWeight)
        {
        }
    }
}
