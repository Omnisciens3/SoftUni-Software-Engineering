using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            double sum = numbers.Sum();
            double average = sum / numbers.Count();

            numbers.Sort();
            numbers.Reverse();

            List<int> biggerThanAverage = new List<int>();

            int count = 0;
            bool isThere = false;
            foreach (int number in numbers)
            {
                if (count == 5)
                {
                    break;
                }
                if (number > average)
                {
                    biggerThanAverage.Add(number);
                    isThere = true;
                }
                count++;
            }
            if (isThere)
            {
                Console.WriteLine(string.Join(' ', biggerThanAverage));
            }
            else
            {
                Console.WriteLine("No");
            }
           
        }
    }
}
