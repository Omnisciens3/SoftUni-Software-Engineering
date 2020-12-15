using System;

namespace _05.Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int end = 8848;
            int daysCount = 1;
            int metersCount = 5364;

            while (command != "END")
            {
                int metersClimbed = int.Parse(Console.ReadLine());
                metersCount += metersClimbed;
                if (command == "Yes")
                {
                    daysCount++;
                    if (daysCount == 5)
                    {
                        Console.WriteLine("Failed!");
                        Console.WriteLine($"{metersCount}");
                        Environment.Exit(0);
                    }
                }
                if (metersCount >= end)
                {
                    Console.WriteLine($"Goal reached for {daysCount} days!");
                    Environment.Exit(0);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Failed!");
            Console.WriteLine($"{metersCount}");
        }
    }
}
