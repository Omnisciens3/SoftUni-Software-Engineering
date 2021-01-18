using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int query = data[0];
                
                switch (query)
                {
                    case 1:
                        int number = data[1];
                        stack.Push(number);
                        break;
                        case 2:
                        if (stack.Count == 0)
                        {
                            continue;
                        }
                        stack.Pop();
                        break;
                        case 3:
                        if (stack.Count != 0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                        case 4:
                        if (stack.Count != 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
