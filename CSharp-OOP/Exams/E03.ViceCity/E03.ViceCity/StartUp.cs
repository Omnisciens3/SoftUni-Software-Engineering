using E03.ViceCity.Core.Contracts;
using E03.ViceCity.Core.Models;
using System;

namespace E03.ViceCity
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
