using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine()
                                                     .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                                     .Select(int.Parse)
                                                     .ToArray());

            Queue<int> threads = new Queue<int>(Console.ReadLine()
                                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                       .Select(int.Parse)
                                                       .ToArray());

            int intValue = int.Parse(Console.ReadLine());

            while (true)
            {
                int taskValue = tasks.Peek();
                int threadValue = threads.Peek();

                if (taskValue == intValue)
                {
                    Console.WriteLine($"Thread with value {threadValue} killed task {taskValue}");
                    break;
                }
                else if (threadValue < taskValue)
                {
                    threads.Dequeue();
                }
                else if (threadValue >= taskValue)
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
            }

            foreach (var item in threads)
            {
                Console.Write(item + " ");
            }

        }
    }
}
