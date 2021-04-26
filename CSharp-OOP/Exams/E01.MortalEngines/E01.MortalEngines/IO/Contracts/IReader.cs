using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace E01.MortalEngines.IO.Contracts
{
    public interface IReader
    {
        IList<ICommand> ReadCommands();
    }
}
