using System;

namespace _06.GodzillaVSKong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double filmBudget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double clothingForOneStatist = double.Parse(Console.ReadLine());
            //Calculations
            double decor = filmBudget * 0.1;
           


            if (statists > 150)
            {
                clothingForOneStatist *= 0.9;
            }
            double finalPriceForClothes = statists * clothingForOneStatist;
            double cash = finalPriceForClothes + decor;
            if (cash <= filmBudget)
            {
                double moneyLeft = filmBudget - cash;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
            }
            else
            {
                double moneyNeeded = cash - filmBudget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:F2} leva more.");
            }

        }
    }
}
