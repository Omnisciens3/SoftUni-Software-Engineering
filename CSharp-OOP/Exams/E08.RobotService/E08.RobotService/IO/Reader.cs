using E08.RobotService.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E08.RobotService.IO
{
    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
