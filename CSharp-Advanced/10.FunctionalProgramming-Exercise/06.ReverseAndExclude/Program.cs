using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());

            numbers.Reverse();

            //Func<int, bool> predicate = num => num % 2 != 0;
            ////numbers = numbers.Where(num => num % 2 != 0).ToList();
            ////numbers = numbers.Where(num => predicate(num)).ToList();
            //numbers = numbers.Where(predicate).ToList();

            Predicate<int> predicate = num => num % n != 0;
            numbers = CustomWhere(numbers, predicate);

            Action<List<int>> print = nums => Console.WriteLine(string.Join(" ", nums));
            print(numbers);
        }

        static List<int> CustomWhere(List<int> numbers, Predicate<int> predicate)
        {
            List<int> newNumbers = new List<int>();

            foreach (int currNum in numbers)
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
