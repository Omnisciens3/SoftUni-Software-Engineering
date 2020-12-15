using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSecondsForOneMeter = double.Parse(Console.ReadLine());
            //Calculations
            double currentTry = distanceInMeters * timeInSecondsForOneMeter;
            double delay = Math.Floor(distanceInMeters / 15) * 12.5;
            double totalTime = currentTry + delay;
            //Output
            if (totalTime < recordInSeconds)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                double secondsSlower = totalTime - recordInSeconds;
                Console.WriteLine($"No, he failed! He was {secondsSlower:f2} seconds slower.");
            }



        }
    }
}
