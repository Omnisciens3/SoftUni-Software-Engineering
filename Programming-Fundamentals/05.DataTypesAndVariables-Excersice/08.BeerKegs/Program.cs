using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxVolumeOfKeg = double.MinValue;
            string biggestKeg = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string kegModel = Console.ReadLine();
                double radiusOfTheKeg = double.Parse(Console.ReadLine());
                int heightOfTheKeg = int.Parse(Console.ReadLine());

                double volumeOfKeg = Math.PI * Math.Pow(radiusOfTheKeg, 2) * heightOfTheKeg;
                
                if (maxVolumeOfKeg < volumeOfKeg)
                {
                    maxVolumeOfKeg = volumeOfKeg;
                    biggestKeg = kegModel;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
