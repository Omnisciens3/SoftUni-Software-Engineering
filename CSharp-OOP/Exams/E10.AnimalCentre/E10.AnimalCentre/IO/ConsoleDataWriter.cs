using E10.AnimalCentre.IO.Contracts;
using System;

namespace E10.AnimalCentre.IO
{
    public class ConsoleDataWriter : IDataWriter
    {
        public void WriteLine(object obj)
        {
            Console.WriteLine(obj);
        }
    }
}
