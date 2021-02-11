using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> bottles = new Stack<int>();
            Queue<int> cups = new Queue<int>();

            int[] cupsCapacity = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] filledBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < cupsCapacity.Length; i++)
            {
                cups.Enqueue(cupsCapacity[i]);
            }

            for (int i = 0; i < filledBottles.Length; i++)
            {
                bottles.Push(filledBottles[i]);
            }

            int wastedWater = 0;

            while (cups.Count > 0)
            {
                if (bottles.Count == 0)
                {
                    break;
                }

                int currentBottle = bottles.Peek();
                int currentCup = cups.Peek();


                if (currentCup - currentBottle <= 0)
                {
                    cups.Dequeue();
                    bottles.Pop();

                    wastedWater += currentBottle - currentCup;
                }
                else
                {
                    currentCup -= currentBottle;
                    bottles.Pop();
                    
                    while (currentCup > 0)
                    {
                        int nextBottle = bottles.Peek();
                        currentCup -= nextBottle;
                        bottles.Pop();
                    }
                    wastedWater += Math.Abs(currentCup);
                    cups.Dequeue();
                }
            }

            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
