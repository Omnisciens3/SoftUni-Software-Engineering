using System;

namespace _0._1IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            int result1 = firstNum + secondNum;
            int result2 = (result1 / thirdNum) * fourthNum;

            Console.WriteLine(result2);

        }
    }
}
