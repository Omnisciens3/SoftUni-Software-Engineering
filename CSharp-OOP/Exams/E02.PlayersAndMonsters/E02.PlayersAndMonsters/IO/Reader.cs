using E02.PlayersAndMonsters.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E02.PlayersAndMonsters.IO
{
    public class Reader : IReader
    {
        public string ReadLine()
        {
            string data = Console.ReadLine();
            return data;
        }
    }
}
