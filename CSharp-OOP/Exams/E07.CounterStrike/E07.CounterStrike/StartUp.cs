using E07.CounterStrike.Core.Contracts;
using E07.CounterStrike.Core.Models;
using System;

namespace E07.CounterStrike
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
