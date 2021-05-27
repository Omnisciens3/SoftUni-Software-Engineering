using E10.AnimalCentre.IO.Contracts;
using System;

namespace E10.AnimalCentre.IO
{
    public class ConsoleDataReader : IDataReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
