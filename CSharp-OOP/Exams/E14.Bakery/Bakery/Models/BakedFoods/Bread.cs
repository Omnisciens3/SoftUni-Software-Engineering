using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.BakedFoods
{
    public class Bread : BakedFood
    {
        const int breadPortion = 200;

        public Bread(string name, decimal price) 
            : base(name, breadPortion, price)
        {
        }
    }
}
