using System;
using System.Collections.Generic;
using System.Text;

namespace E11.StorageMaster.Models.Products
{
    public class Gpu : Product
    {
        private const double DefaultWeight = 0.7;

        public Gpu(double price)
            : base(price, DefaultWeight)
        {
        }
    }
}
