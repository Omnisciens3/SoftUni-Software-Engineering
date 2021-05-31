using E11.StorageMaster.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E11.StorageMaster.IO
{
    public class ConsoleDataWriter : IWriter
    {
        public void WriteLine(object obj)
        {
            Console.WriteLine(obj);
        }
    }
}
