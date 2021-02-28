using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfWaves = int.Parse(Console.ReadLine());

            List<int> defencePlates = new List<int>(Console.ReadLine()
                                                             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                             .Select(int.Parse)
                                                             .ToArray());

            Stack<int> orcs = new Stack<int>();

            int waves = 1;
            for (int i = 0; i < numberOfWaves; i++)
            {
                orcs = new Stack<int>(Console.ReadLine()
                                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                     .Select(int.Parse)
                                                     .ToArray());

                if (waves % 3 == 0)
                {
                    int plateToAdd = int.Parse(Console.ReadLine());
                    defencePlates.Add(plateToAdd);
                }

                waves++;

                while (orcs.Count > 0 && defencePlates.Count > 0)
                {
                    int currentPlate = defencePlates[0];
                    int currentOrc = orcs.Peek();
                    int index = 0;
                    if (currentPlate == currentOrc)
                    {
                        defencePlates.RemoveAt(index);
                        orcs.Pop();
                    }
                    else if (currentPlate > currentOrc)
                    {
                        orcs.Pop();
                        defencePlates[0] -= currentOrc;
                    }
                    else
                    {
                        defencePlates.RemoveAt(index);
                        orcs.Pop();
                        orcs.Push(currentOrc - currentPlate);

                        if (defencePlates.Count == 0)
                        {
                            break;
                        }
                    }
                }

                if (defencePlates.Count == 0)
                {
                    break;
                }
            }

            Queue<int> queue = new Queue<int>(defencePlates);

            if (defencePlates.Count > 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", queue)}");
            }
            else
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", orcs)}");
            }
        }
    }
}
