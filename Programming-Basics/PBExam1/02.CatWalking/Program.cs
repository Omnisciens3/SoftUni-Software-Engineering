using System;

namespace _02.CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesForWalking = int.Parse(Console.ReadLine());
            int numberOfWalks = int.Parse(Console.ReadLine());
            int numberOfCalories = int.Parse(Console.ReadLine());

            int totalMinutesPerDay = minutesForWalking * numberOfWalks;
        }
    }
}
