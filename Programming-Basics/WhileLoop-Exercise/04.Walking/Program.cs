using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            int stepsMade = 0;

            while (stepsMade < goal)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    stepsMade += stepsToHome;
                    break;
                }
                else
                {
                    int steps = int.Parse(input);
                    stepsMade += steps;
                }
            }
            if (stepsMade >= goal)
            {
                int difference = stepsMade - goal;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{difference} steps over the goal!");
            }
            else
            {
                int stepsLeft = goal - stepsMade;
                Console.WriteLine($"{stepsLeft} more steps to reach goal.");
            }
        }
    }
}
