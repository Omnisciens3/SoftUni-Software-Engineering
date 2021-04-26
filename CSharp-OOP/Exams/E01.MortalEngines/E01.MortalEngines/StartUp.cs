using E01.MortalEngines.Core.Contracts;
using E01.MortalEngines.Core.Models;
using System;

namespace E01.MortalEngines
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
