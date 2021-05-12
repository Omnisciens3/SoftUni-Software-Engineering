using E05.MXGP.Core;
using E05.MXGP.Core.Contracts;
using System;

namespace E05.MXGP
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
