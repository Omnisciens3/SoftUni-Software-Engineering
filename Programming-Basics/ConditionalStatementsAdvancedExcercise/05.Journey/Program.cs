using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double moneyForSpending = 0;
            
            string campHotel = "";

            if (budget <= 100)
            {
                switch (season)
                {
                    
                    case "summer":
                        moneyForSpending = budget * 0.30;
                        break;
                    case "winter":
                        moneyForSpending = budget * 0.70;
                        break;
                }
                if (season == "summer")
                {
                    campHotel = "Camp";
                }
                else
                {
                    campHotel = "Hotel";
                }
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine($"{campHotel} - {moneyForSpending:f2}");
            }
            else if (budget <= 1000)
            {
                switch (season)
                {

                    case "summer":
                        moneyForSpending = budget * 0.40;
                        break;
                    case "winter":
                        moneyForSpending = budget * 0.80;
                        break;
                }
                if (season == "summer")
                {
                    campHotel = "Camp";
                }
                else
                {
                    campHotel = "Hotel";
                }
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine($"{campHotel} - {moneyForSpending:f2}");
            }
            else
            {
                moneyForSpending = budget * 0.90;
                campHotel = "Hotel";
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"{campHotel} - {moneyForSpending:f2}");
            }
        }
    }
}
