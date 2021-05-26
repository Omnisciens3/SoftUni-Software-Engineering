using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Core
{
    public interface ICommandInterpreter
    {
        string ExecuteCommand(string[] data, IController controller);
    }
}
