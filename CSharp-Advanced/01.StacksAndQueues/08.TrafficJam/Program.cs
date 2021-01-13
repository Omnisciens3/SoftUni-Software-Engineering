using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCarsToPass = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            int numberOfCarsPassed = 0;
            while (input != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < numberOfCarsToPass; i++)
                    {
                        if (queue.Count == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(queue.Dequeue() + " passed!");
                            numberOfCarsPassed++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(numberOfCarsPassed + " cars passed the crossroads.");
        }
    }
}
