using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberOne = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> numberTwo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(numberOne.Count, numberTwo.Count); i++)
            {
                result.Add(numberOne[i]);
                result.Add(numberTwo[i]);
            }

            for (int i = Math.Min(numberOne.Count, numberTwo.Count); i < Math.Max(numberOne.Count, numberTwo.Count); i++)
            {
                if (i >= numberOne.Count)
                {
                    result.Add(numberTwo[i]);
                }
                else
                {
                    result.Add(numberOne[i]);
                }
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
