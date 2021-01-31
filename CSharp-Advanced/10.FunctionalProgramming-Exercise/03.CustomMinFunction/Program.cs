using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //int minNumber = numbers.Min();
            Func<List<int>, int> minNumber =
                numbers =>
                {
                    int minNum = int.MaxValue;

                    foreach (int num in numbers)
                    {
                        if (num < minNum)
                        {
                            minNum = num;
                        }
                    }
                    return minNum;
                };

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int result = minNumber(numbers);
            Console.WriteLine(result);
        }
    }
}
