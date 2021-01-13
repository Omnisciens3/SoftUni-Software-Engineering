using System;
using System.Collections.Generic;

namespace _07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();
            Queue<string> queue = new Queue<string>(kids);
            int n = int.Parse(Console.ReadLine());

            int potatoTosses = 0;

            while (queue.Count > 1)
            {
                potatoTosses++;
                string kid = queue.Dequeue();

                if (potatoTosses == n)
                {
                    potatoTosses = 0;
                    Console.WriteLine("Removed " + kid);
                }
                else
                {
                    queue.Enqueue(kid);
                }
            }

            Console.WriteLine("Last is " + queue.Dequeue());
        }
    }
}
