using E06.SantaWorkshop.Core.Contracts;
using E06.SantaWorkshop.Core.Models;
using System;

namespace E06.SantaWorkshop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
