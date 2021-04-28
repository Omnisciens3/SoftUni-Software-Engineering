﻿using E02.PlayersAndMonsters.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E02.PlayersAndMonsters.IO
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
