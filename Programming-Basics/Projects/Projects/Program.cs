using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int time = 3;
            int projects = int.Parse(Console.ReadLine());

            int timeneeded = time * projects;



            Console.WriteLine($"The architect {name} will need {timeneeded} hours to complete {projects} project/s.");

        }
    }
}
