using E02.PlayersAndMonsters.Core;
using E02.PlayersAndMonsters.Core.Contracts;
using System;

namespace E02.PlayersAndMonsters
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
