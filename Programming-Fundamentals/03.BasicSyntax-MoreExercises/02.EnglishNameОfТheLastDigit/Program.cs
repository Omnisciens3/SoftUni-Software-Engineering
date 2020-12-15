using System;

namespace _02.EnglishNameОfТheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int lastNum = num % 10;
            string result = string.Empty;
            
            if (lastNum == 1)
            {
                result = "one";
            }
            else if (lastNum == 2)
            {
                result = "two";
            }
            else if (lastNum == 3)
            {
                result = "three";
            }
            else if (lastNum == 4)
            {
                result = "four";
            }
            else if (lastNum == 5)
            {
                result = "five";
            }
            else if (lastNum == 6)
            {
                result = "six";
            }
            else if (lastNum == 7)
            {
                result = "seven";
            }
            else if (lastNum == 8)
            {
                result = "eight";
            }
            else if (lastNum == 9)
            {
                result = "nine";
            }
            else
            {
                result = "zero";
            }
            Console.WriteLine(result);
        }
    }
}
