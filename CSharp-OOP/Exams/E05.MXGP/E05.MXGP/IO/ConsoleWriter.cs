using E05.MXGP.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E05.MXGP.IO
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public void Write(string message)
        {
            Console.Write(message);
        }
    }
}
