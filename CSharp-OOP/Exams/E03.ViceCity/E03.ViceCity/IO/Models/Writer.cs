using E03.ViceCity.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E03.ViceCity.IO.Models
{
    public class Writer : IWriter
    {
        public void Write(string line)
        {
            Console.Write(line);
        }

        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
