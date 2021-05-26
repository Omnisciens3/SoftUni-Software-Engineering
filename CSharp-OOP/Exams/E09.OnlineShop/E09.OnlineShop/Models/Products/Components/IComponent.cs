using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Components
{
    public interface IComponent : IProduct
    {
        int Generation { get; }
    }
}
