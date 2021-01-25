using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] setOfElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = setOfElements[0];
            int m = setOfElements[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < n + m; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (i < n)
                {
                    firstSet.Add(currentNum);
                }
                else
                {
                    secondSet.Add(currentNum);
                }
            }

            foreach (var num in firstSet)
            {
                if (secondSet.Contains(num))
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
