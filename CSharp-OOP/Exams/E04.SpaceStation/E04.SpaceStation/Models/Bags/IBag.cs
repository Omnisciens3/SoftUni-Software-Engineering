using System;
using System.Collections.Generic;
using System.Text;

namespace E04.SpaceStation.Models.Bags
{
    public interface IBag
    {
        ICollection<string> Items { get; }
    }
}
