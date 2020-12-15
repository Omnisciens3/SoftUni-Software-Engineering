using System;

namespace _06.VetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hoursPerDay = int.Parse(Console.ReadLine());

            double totalSum = 0;

            for (int day = 1; day <= days; day++)
            {
                double daySum = 0;
                for (int hours = 1; hours <= hoursPerDay; hours++)
                {
                   
                    if (day % 2 == 0 && hours % 2 != 0)
                    {
                        daySum += 2.50;
                    }
                    else if (day % 2 != 0 && hours % 2 == 0)
                    {
                        daySum += 1.25;
                    }
                    else
                    {
                        daySum += 1;
                    }
                }
                totalSum += daySum;
                Console.WriteLine($"Day: {day} - {daySum:f2} leva");
            }
            Console.WriteLine($"Total: {totalSum:f2} leva");
        }
    }
}
