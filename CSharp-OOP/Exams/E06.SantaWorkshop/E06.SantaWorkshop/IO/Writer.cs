using E06.SantaWorkshop.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E06.SantaWorkshop.IO
{
    public class Writer : IWriter
    {
        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
