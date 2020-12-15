using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToList();

            int[] bombPower = Console.ReadLine()
                                     .Split()
                                     .Select(int.Parse)
                                     .ToArray();

            int bomb = bombPower[0];
            int power = bombPower[1];

            for (int i = 0; i < sequence.Count; i++)
            {
                int currentNumber = sequence[i];

                if (currentNumber == bomb)
                {
                    int startIndex = i - power;
                    int endIndex = i + power;

                    if (startIndex < 0) //с тези две проверки си гарантираме, че няма да излезем извън range-a
                    {
                        startIndex = 0;
                    }

                    if (endIndex > sequence.Count - 1)
                    {
                        endIndex = sequence.Count - 1;
                    }

                    int endIndexToRemove = endIndex - startIndex + 1;

                    sequence.RemoveRange(startIndex, endIndexToRemove);

                    i = startIndex - 1; // защото премахваме числа от фор цикъла - за да не излезем извън range-a.
                }
            }

            Console.WriteLine(sequence.Sum());
        }
    }
}
