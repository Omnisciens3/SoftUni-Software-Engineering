using E08.RobotService.Core.Contracts;
using E08.RobotService.Core.Models;
using System;

namespace E08.RobotService
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Don't forget to comment out the commented code lines in the Engine class!
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
