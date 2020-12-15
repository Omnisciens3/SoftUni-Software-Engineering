using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            TheSmallestNumberIs(number1, number2, number3);
        }

        private static void TheSmallestNumberIs(int number1, int number2, int number3)
        {
            int smallestNum = int.MaxValue;
            if (smallestNum > number1)
            {
                smallestNum = number1;
            }
            if (smallestNum > number2)
            {
                smallestNum = number2;
            }
            if (smallestNum > number3)
            {
                smallestNum = number3;
            }
            Console.WriteLine(smallestNum);
        }
    }
}
