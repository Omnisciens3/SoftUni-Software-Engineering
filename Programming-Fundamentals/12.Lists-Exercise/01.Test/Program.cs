using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToList();

            int maxCapacityOfAWagon = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArgs = command.Split(); // взимаме командата и я правим на масив.

                if (cmdArgs[0] == "Add")
                {
                    wagons.Add(int.Parse(cmdArgs[1]));
                }
                else
                {
                    int passengers = int.Parse(cmdArgs[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currentWagon = wagons[i];
                        if (currentWagon + passengers <= maxCapacityOfAWagon)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
