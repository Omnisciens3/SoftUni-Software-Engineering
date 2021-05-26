using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Peripherals
{
    public interface IPeripheral : IProduct
    {
        string ConnectionType { get; }
    }
}
