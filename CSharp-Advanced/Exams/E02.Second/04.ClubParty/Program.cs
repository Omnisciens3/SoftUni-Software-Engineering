using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace _04.ClubParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCapacity = int.Parse(Console.ReadLine());

            Stack<string> input = new Stack<string>(Console.ReadLine().Split());

            Queue<string> halls = new Queue<string>();
            Queue<int> reservations = new Queue<int>();

            while (input.Count > 0)
            {
                string elementToAdd = input.Peek();

                char currentElement = char.Parse(input.Peek().First().ToString());
                if (Char.IsDigit(currentElement) && halls.Count == 0)
                {
                    input.Pop();
                    continue;
                }

                if (Char.IsLetter(currentElement))
                {
                    halls.Enqueue(elementToAdd);
                    input.Pop();
                }
                else
                {
                    reservations.Enqueue(int.Parse(elementToAdd));
                    input.Pop();
                }
            }

            Dictionary<string, List<int>> keyValuePairs = new Dictionary<string, List<int>>();

            while (halls.Count > 0 && reservations.Count > 0)
            {
                int sum = 0;
                string currentHall = halls.Dequeue();
                int currentReservation = reservations.Dequeue();
                sum += currentReservation;

                if (currentReservation <= maxCapacity)
                {
                    keyValuePairs.Add(currentHall, new List<int>());
                    keyValuePairs[currentHall].Add(currentReservation);
                }

                int beforeSum = 0;

                while (sum <= maxCapacity && reservations.Count > 0)
                {
                    int nextReservation = reservations.Peek();
                    beforeSum = sum;
                    sum += nextReservation;

                    if (sum <= maxCapacity)
                    {
                        keyValuePairs[currentHall].Add(nextReservation);
                        reservations.Dequeue();
                    }
                }

                if (halls.Count == 0 && beforeSum != maxCapacity)
                {
                    keyValuePairs.Remove(currentHall);
                }
            }

            foreach (var hall in keyValuePairs)
            {
                Console.WriteLine($"{hall.Key} -> {string.Join(", ", hall.Value)}");
            }
        }
    }
}
