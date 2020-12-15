using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static Prices

            double puzzle = 2.6;
            double speakingDoll = 3;
            double teddyBear = 4.1;
            double minion = 8.2;
            double truck = 2;

            //Input

            double tripPrice = double.Parse(Console.ReadLine());
            int puzzlesN = int.Parse(Console.ReadLine());
            int speakingDollN = int.Parse(Console.ReadLine());
            int teddyBearN = int.Parse(Console.ReadLine());
            int minionN = int.Parse(Console.ReadLine());
            int truckN = int.Parse(Console.ReadLine());

            //Calculations

            double sum = puzzlesN * puzzle + speakingDollN * speakingDoll + teddyBear * teddyBearN + minion * minionN + truck * truckN;
            int numberOfToysSold = puzzlesN + speakingDollN + teddyBearN + minionN + truckN;
            if (numberOfToysSold >=50)
            {
                sum *= 0.75;

            }

            sum *= 0.90;

            if (sum >= tripPrice)
            {
                double moneyLeft = sum - tripPrice;

                Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");


            }
            else
            {
                double moneyNeeded = tripPrice - sum;

                Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
            }




        }
    }
}
