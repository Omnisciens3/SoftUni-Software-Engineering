using System;
using System.Linq;

namespace _07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] arrayB = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sumA = 0;

            for (int i = 0; i < arrayA.Length; i++)
            {
                sumA += arrayA[i];
                if (arrayA[i] != arrayB[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    Environment.Exit(0);
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sumA}");
        }
    }
}
