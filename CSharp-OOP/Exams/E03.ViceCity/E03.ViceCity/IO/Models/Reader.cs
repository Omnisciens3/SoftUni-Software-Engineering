using E03.ViceCity.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E03.ViceCity.IO.Models
{
    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
