using E04.SpaceStation.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E04.SpaceStation.IO
{
    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
