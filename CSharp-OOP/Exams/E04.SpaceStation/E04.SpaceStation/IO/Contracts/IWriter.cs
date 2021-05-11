using System;
using System.Collections.Generic;
using System.Text;

namespace E04.SpaceStation.IO.Contracts
{
    public interface IWriter
    {
        void WriteLine(string message);

        void Write(string message);
    }
}
