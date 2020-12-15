using System;

namespace _04.Rate
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputSumS = double.Parse(Console.ReadLine());
            int numberOfMonths = int.Parse(Console.ReadLine());

            double simpleSum = inputSumS;
            double complexSum = inputSumS;

            for (int months = 1; months <= numberOfMonths ; months++)
            {
                simpleSum += inputSumS * 0.03;
                complexSum += complexSum * 0.027;
            }
            Console.WriteLine($"Simple interest rate: {simpleSum:f2} lv.");
            Console.WriteLine($"Complex interest rate: {complexSum:f2} lv.");
            if (complexSum > simpleSum)
            {
                double difference = complexSum - simpleSum;
                Console.WriteLine($"Choose a complex interest rate. You will win {difference:f2} lv.");
            }
            else
            {
                double difference2 = simpleSum - complexSum;
                Console.WriteLine($"Choose a simple interest rate. You will win {difference2:f2} lv.");
            }
        }
    }
}
