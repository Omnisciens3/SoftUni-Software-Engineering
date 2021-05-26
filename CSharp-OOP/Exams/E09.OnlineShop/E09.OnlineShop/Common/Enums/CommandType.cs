using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Common.Enums
{
    public enum CommandType
    {
        AddComputer = 1,
        AddPeripheral = 2,
        RemovePeripheral = 3,
        AddComponent = 4,
        RemoveComponent = 5,
        BuyComputer = 6,
        BuyBestComputer = 7,
        GetComputerData = 8,
        Close = 9,
    }
}
