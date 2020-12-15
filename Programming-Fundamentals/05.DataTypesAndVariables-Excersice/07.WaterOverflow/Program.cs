using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFills = int.Parse(Console.ReadLine());
            int totalLitres = 0;

            for (int i = 0; i < numberOfFills; i++)
            {
                int litresFilled = int.Parse(Console.ReadLine());
                totalLitres += litresFilled;
                if (totalLitres > 255)
                {
                    totalLitres -= litresFilled;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(totalLitres);
        }
    }
}
