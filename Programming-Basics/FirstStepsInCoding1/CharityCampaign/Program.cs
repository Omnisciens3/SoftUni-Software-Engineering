using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static data

            int cake = 45;
            double waffle = 5.8;
            double pancake = 3.2;

            //Input

            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            //Calc

            double sumCakesPerDay = cake * cakes;
            double sumWafflesPerDay = waffle * waffles;
            double sumPancakesPerDay = pancake * pancakes;
            double totalSumPerDay = (sumCakesPerDay + sumPancakesPerDay + sumWafflesPerDay) * bakers;
            double totalSum = totalSumPerDay * days;
            double totalSumAfter = totalSum - (totalSum / 8);

            //Output

            Console.WriteLine(totalSumAfter);




        }
    }
}
