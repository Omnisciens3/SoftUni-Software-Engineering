using E04.SpaceStation.Core.Contracts;
using E04.SpaceStation.Core.Models;
using System;

namespace E04.SpaceStation
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
