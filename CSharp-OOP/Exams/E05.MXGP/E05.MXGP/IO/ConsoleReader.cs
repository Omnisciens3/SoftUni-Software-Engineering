using E05.MXGP.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E05.MXGP.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
