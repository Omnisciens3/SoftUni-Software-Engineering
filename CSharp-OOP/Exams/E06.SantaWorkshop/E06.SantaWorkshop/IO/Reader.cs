using E06.SantaWorkshop.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E06.SantaWorkshop.IO
{
    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
