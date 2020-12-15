using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();

                string command = tokens[0];
                int index = int.Parse(tokens[1]);
                int value = int.Parse(tokens[2]);

                if (index < 0 || index >= targets.Count)
                {
                    if (command == "Add")
                    {
                        Console.WriteLine("Invalid placement!");
                    }

                    continue;
                }

                switch (command)
                {
                    case "Shoot":

                        targets[index] -= value;

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                        break;

                    case "Add":
                        targets.Insert(index, value);
                        break;

                    case "Strike":

                        if (index - value < 0 || index + value >= targets.Count)
                        {
                            Console.WriteLine("Strike missed!");
                            continue;
                        }

                        targets.RemoveRange(index - value, (value * 2) + 1);
                        break;
                }

            }

            Console.WriteLine(string.Join('|', targets));
        }
    }
}
