
using System;
using System.Data.Common;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            double result = Calculate(firstNum, @operator, secondNum);
            Console.WriteLine(result);
        }

        private static double Calculate(int firstNum, string @operator, int secondNum)
        {
            double result = 0;

            switch (@operator)
            {
                case "/":
                    result = firstNum / secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
            }

            return result;
        }
    }
}
