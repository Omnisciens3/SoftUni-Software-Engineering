using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int amountAfterConsumpt = 0;
            int daysCount = 0;
            int totalAmount = 0;
            while (startingYield >= 100)
            {
                amountAfterConsumpt = startingYield - 26;
                startingYield -= 10;
                totalAmount += amountAfterConsumpt;
                daysCount++;
            }
            if (totalAmount < 26)
            {
                Console.WriteLine(daysCount);
                Console.WriteLine(totalAmount);
            }
            else
            {
                totalAmount -= 26;
                Console.WriteLine(daysCount);
                Console.WriteLine(totalAmount);
            }

        }
    }
}
