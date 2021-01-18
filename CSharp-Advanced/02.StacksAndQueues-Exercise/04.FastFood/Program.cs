﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < orders.Length; i++)
            {
                queue.Enqueue(orders[i]);
            }

            Console.WriteLine(queue.Max());
            
            while (queue.Count > 0)
            {
                int currentOrder = queue.Peek();

                if (currentOrder <= quantityOfFood)
                {
                    queue.Dequeue();
                    quantityOfFood -= currentOrder;
                }
                else
                {
                    break;
                }
            }

            if (queue.Count != 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
