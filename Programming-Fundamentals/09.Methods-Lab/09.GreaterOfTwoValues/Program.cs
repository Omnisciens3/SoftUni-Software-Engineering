using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();

            GetMaxValue(value);
        }

        private static void GetMaxValue(string value)
        {
            if (value == "int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                int maxValue = int.MinValue;

                if (maxValue < firstNum)
                {
                    maxValue = firstNum;
                }

                if (maxValue < secondNum)
                {
                    maxValue = secondNum;
                }
                Console.WriteLine(maxValue);
            }

            else if (value == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());

                if (firstChar.CompareTo(secondChar) < secondChar.CompareTo(firstChar))
                {
                    Console.WriteLine(secondChar);
                }
                else
                {
                    Console.WriteLine(firstChar);
                }
            }

            else if (value == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();

                if (firstString.CompareTo(secondString) < secondString.CompareTo(firstString))
                {
                    Console.WriteLine(secondString);
                }
                else
                {
                    Console.WriteLine(firstString);
                }
            }
        }
    }
}
