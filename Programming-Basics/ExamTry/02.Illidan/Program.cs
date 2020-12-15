using System;

namespace _02.Illidan
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int powerOfOnePerson = int.Parse(Console.ReadLine());
            int healthOfIliden = int.Parse(Console.ReadLine());

            int totalPowerOfPeople = numberOfPeople * powerOfOnePerson;

            if (totalPowerOfPeople < healthOfIliden)
            {
                int powerNeeded = healthOfIliden - totalPowerOfPeople;
                Console.WriteLine($"You are not prepared! You need {powerNeeded} more points.");
            }
            else
            {
                int power = totalPowerOfPeople - healthOfIliden;
                Console.WriteLine($"Illidan has been slain! You defeated him with {power} points.");
            }
        }
    }
}
