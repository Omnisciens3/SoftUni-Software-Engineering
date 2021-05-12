using System;
using System.Collections.Generic;
using System.Text;

namespace E05.MXGP.IO.Contracts
{
    public interface IWriter
    {
        void WriteLine(string message);

        void Write(string message);
    }
}
