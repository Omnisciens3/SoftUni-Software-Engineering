using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _06.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighbourhood = Console.ReadLine()
                                            .Split('@', StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToArray();
            int jumpedPosition = 0;
            string input;

            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] command = input.Split();
                
                int jumpLenght = int.Parse(command[1]);

                jumpedPosition += jumpLenght;

                if (jumpedPosition >= 0 && jumpedPosition < neighbourhood.Length)
                {
                    neighbourhood[jumpedPosition] -= 2;
                }
                else
                {
                    jumpedPosition = 0;
                    neighbourhood[jumpedPosition] -= 2;
                }

                if (neighbourhood[jumpedPosition] == 0)
                {
                    Console.WriteLine($"Place {jumpedPosition} has Valentine's day.");
                }
                else if (neighbourhood[jumpedPosition] < 0)
                {
                    Console.WriteLine($"Place {jumpedPosition} already had Valentine's day.");
                }
            }

            Console.WriteLine($"Cupid's last position was {jumpedPosition}.");

            int failedCount = neighbourhood.Count(x => x > 0);

            if (failedCount == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failedCount} places.");
            }
        }
    }
}
