using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sorted = input.OrderByDescending(n => n).ToArray();
            int count = 0;

            for (int i = 0; i < sorted.Length; i++)
            {
                count++;

                if (count == 4)
                {
                    break;
                }

                Console.Write(sorted[i] + " ");
            }
        }
    }
}
