using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacityOfRack = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < clothes.Length; i++)
            {
                stack.Push(clothes[i]);
            }

            int rackSum = 1;
            int currentRack = capacityOfRack;

            while (stack.Count > 0)
            {
                int currentClothes = stack.Peek();
                
                if (currentRack >= currentClothes)
                {
                    currentRack -= currentClothes;
                    stack.Pop();
                }
                else
                {
                    rackSum++;
                    currentRack = capacityOfRack;
                }
            }

            Console.WriteLine(rackSum);
        }
    }
}
