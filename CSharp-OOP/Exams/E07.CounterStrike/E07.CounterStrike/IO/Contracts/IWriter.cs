﻿using System;
using System.Collections.Generic;
using System.Text;

namespace E07.CounterStrike.IO.Contracts
{
    public interface IWriter
    {
        void WriteLine(string message);

        void Write(string message);
    }
}
