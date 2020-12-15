using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input

            int depositSum = int.Parse(Console.ReadLine());
            int monthDeposit = int.Parse(Console.ReadLine());
            double yearRate = double.Parse(Console.ReadLine());

            //Calc
            double interest = depositSum * yearRate / 100;
                double interestPerMonth = interest / 12;
            double totalSum = depositSum + (monthDeposit * interestPerMonth);

            //Output

            Console.WriteLine(totalSum);

              
        }
    }
}
