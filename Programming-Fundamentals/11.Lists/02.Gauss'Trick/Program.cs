using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxIndex = number.Count / 2; //за да разцепим листа на 2 части.

            for (int i = 0; i < maxIndex; i++)
            {
                number[i] += number[number.Count - 1];
                number.Remove(number[number.Count - 1]); // за да премахнем последната цифра, която вече сме събрали с                                                                                                  първата.
            }

            Console.WriteLine(string.Join(" ", number));
        }
    }
}
