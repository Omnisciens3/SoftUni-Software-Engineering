using System;

namespace _01.CookingMasterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceForAPackageOfFlour = double.Parse(Console.ReadLine());
            double priceForAnEgg = double.Parse(Console.ReadLine());
            double priceForAnApron = double.Parse(Console.ReadLine());

            double numberOfAprons = Math.Ceiling(students + (students * 0.2));
            double priceForAprons = numberOfAprons * priceForAnApron;
            int count = 0;
            double freePackagesFlour = 0;
            for (int i = 0; i < students; i++)
            {
                count++;
                if (count % 5 == 0)
                {
                    freePackagesFlour++;
                }
            }
            double totalPriceForFlour = (students - freePackagesFlour) * priceForAPackageOfFlour;
            double neededMoney = students * priceForAnEgg * 10 + priceForAprons + totalPriceForFlour;

            if (budget >= neededMoney)
            {
                Console.WriteLine($"Items purchased for {neededMoney:f2}$.");
            }
            else
            {
                Console.WriteLine($"{neededMoney - budget:f2}$ more needed.");
            }
        }
    }
}
