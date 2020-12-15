using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                if (currentNum % 2 == 0)
                {
                    evenSum += currentNum;
                }
                else
                {
                    oddSum += currentNum;
                }
            }
            Console.WriteLine(evenSum - oddSum);
        }
    }
}
