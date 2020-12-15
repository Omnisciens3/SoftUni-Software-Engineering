using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string gameName = Console.ReadLine();
            double totalSpent = 0;

            while (gameName != "Game Time")
            {
                double price = 0;
                
                switch (gameName)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        gameName = Console.ReadLine();
                        continue;
                }
                if (currentBalance >= price)
                {
                    Console.WriteLine($"Bought {gameName}");
                }
                else if (currentBalance < price)
                {
                    Console.WriteLine("Too Expensive");
                    gameName = Console.ReadLine();
                    continue;
                }
                currentBalance -= price;
                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    Environment.Exit(0);
                }
                totalSpent += price;
                gameName = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");
        }
    }
}
