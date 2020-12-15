using System;

namespace _11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceOfWashingMachine = double.Parse(Console.ReadLine());
            double pricePerToy = double.Parse(Console.ReadLine());

            double toyCount = 0;
            double money = 0;
            double plusMoney = 10;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    toyCount++;
                }
                else
                {
                    money += plusMoney;
                    plusMoney += 10;
                }
            }
            money -= age / 2;
            money += toyCount * pricePerToy;

            double leftMoney = money - priceOfWashingMachine;
            double moneyNeeded = Math.Abs(money - priceOfWashingMachine);
            if (money >= priceOfWashingMachine)
            {
                Console.WriteLine($"Yes! {leftMoney:f2}");
            }
            else
            {
                Console.WriteLine($"No! {moneyNeeded:f2}");
            }
        }
    }
}
