using System;
using System.Collections.Generic;
using System.Text;

namespace E06.SantaWorkshop.IO.Contracts
{
    public interface IWriter
    {
        void WriteLine(string message);

        void Write(string message);
    }
}
