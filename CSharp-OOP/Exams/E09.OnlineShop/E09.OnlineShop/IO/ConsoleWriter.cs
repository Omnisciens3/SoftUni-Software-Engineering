using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.IO
{
    public class ConsoleWriter : IWriter
    {
        public void CustomWriteLine(string text)
        {
            Console.WriteLine(text);
        }

        public void CustomWrite(string text)
        {
            Console.Write(text);
        }
    }
}
