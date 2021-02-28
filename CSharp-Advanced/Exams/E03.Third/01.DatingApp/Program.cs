using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> males = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Queue<int> females = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int matches = 0;

            while (males.Count > 0 && females.Count > 0)
            {
                int maleValue = males.Peek();
                int femaleValue = females.Peek();

                if (maleValue <= 0)
                {
                    males.Pop();
                    continue;
                }

                if (femaleValue <= 0)
                {
                    females.Dequeue();
                    continue;
                }

                if (maleValue % 25 == 0)
                {
                    males.Pop();

                    if (males.Count > 0)
                    {
                        males.Pop();
                    }

                    continue;
                }

                if (femaleValue % 25 == 0)
                {
                    females.Dequeue();

                    if (females.Count > 0)
                    {
                        females.Dequeue();
                    }

                    continue;
                }

                if (maleValue == femaleValue)
                {
                    matches++;
                    males.Pop();
                    females.Dequeue();
                }
                else
                {
                    females.Dequeue();
                    males.Pop();
                    males.Push(maleValue - 2); // променяме стойността с 2. Decrease by 2;
                }

            }

            Console.WriteLine($"Matches: {matches}");

            //if (males.Count > 0)
            //{
            //    Console.WriteLine($"Males left: {string.Join(", ", males)}");
            //}
            //else
            //{
            //    Console.WriteLine("Males left: none");
            //}

            //този ред спестява горните иф проверки.
            string malesString = males.Count > 0 ? string.Join(", ", males) : "none"; 

            Console.WriteLine($"Males left: {malesString}");

            //if (females.Count > 0)
            //{
            //    Console.WriteLine($"Females left: {string.Join(", ", females)}");
            //}
            //else
            //{
            //    Console.WriteLine("Females left: none");
            //}

            string femalesString = females.Count > 0 ? string.Join(", ", females) : "none";

            Console.WriteLine($"Females left: {femalesString}");
        }
    }
}
