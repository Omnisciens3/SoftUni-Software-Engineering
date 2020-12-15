using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForTrip = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());

            int spendingMoney = 0;
            int days = 0;
            while (currentMoney < moneyForTrip)
            {
                days++;
                string activity = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                if (activity == "spend")
                {
                    spendingMoney++;
                    if (spendingMoney == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{days}");
                        Environment.Exit(0);
                    }
                    currentMoney -= money;
                    if (currentMoney < 0)
                    {
                        currentMoney = 0;
                    }
                }
                if (activity == "save")
                {
                    spendingMoney = 0;
                    currentMoney += money;
                }
            }
            Console.WriteLine($"You saved the money for {days} days.");
        }
    }
}
