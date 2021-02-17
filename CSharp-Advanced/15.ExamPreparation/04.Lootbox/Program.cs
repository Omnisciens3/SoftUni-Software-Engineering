using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine()
                                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                     .Select(int.Parse)
                                                     .ToArray());

            Stack<int> secondBox = new Stack<int>(Console.ReadLine()
                                                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                      .Select(int.Parse)
                                                      .ToArray());
            int sum = 0;

            while (firstBox.Count > 0 && secondBox.Count > 0)
            {
                int firstNum = firstBox.Peek();
                int secondNum = secondBox.Peek();
                int summedItems = (firstNum + secondNum);

                if (summedItems % 2 == 0)
                {
                    sum += summedItems;
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    int itemToMove = secondBox.Pop();
                    firstBox.Enqueue(itemToMove);
                }
            }

            if (firstBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (sum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sum}");
            }
        }
    }
}
