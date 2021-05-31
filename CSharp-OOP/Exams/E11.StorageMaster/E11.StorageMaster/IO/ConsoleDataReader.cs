using E11.StorageMaster.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E11.StorageMaster.IO
{
    public class ConsoleDataReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
