using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int start = range[0];
            int end = range[1];
            string criteria = Console.ReadLine();

            Func<int, int, List<int>> rangeOfNumbers = (s, e) =>
            {
                List<int> nums = new List<int>();

                for (int i = s; i <= e; i++)
                {
                    nums.Add(i);
                }

                return nums;
            };

            List<int> numbers = rangeOfNumbers(start, end);

            Predicate<int> predicate = n => true;

            if (criteria == "odd")
            {
                predicate = n => n % 2 != 0;
            }
            else if (criteria == "even")
            {
                predicate = n => n % 2 == 0;
            }
            //numbers.Where(n => n % 2 == 0);
            //CustomWhere(numbers, n => n % 2 == 0); //горното върши същата работа като нашето, но има предикат. Where ot LINQ приема функция, а не предикат. Затова си направихме наш собствен Where.

            Console.WriteLine(string.Join(" ", CustomWhere(numbers, predicate)));
        }

        static List<int> CustomWhere(List<int> numbers, Predicate<int> predicate)
        {
            List<int> newNumbers = new List<int>();

            foreach (int  currNum in numbers)
            {
                if (predicate(currNum))
                {
                    newNumbers.Add(currNum);
                }
            }

            return newNumbers;
        }
    }
}
