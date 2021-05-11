﻿using E04.SpaceStation.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E04.SpaceStation.IO
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
