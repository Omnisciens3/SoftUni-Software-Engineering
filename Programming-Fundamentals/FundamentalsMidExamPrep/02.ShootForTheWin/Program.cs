using System;
using System.Linq;

namespace _02.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();
            int count = 0;

            while (input != "End")
            {
                int index = int.Parse(input);

                if (index < 0 || index >= targets.Length || targets[index] == -1) //с target index проверяваме дали                                                                         мишената вече не е била улучена
                {
                    input = Console.ReadLine(); //за да не стане безкраен цикъла.

                    continue;
                }

                int shotTarget = targets[index];
                targets[index] = -1;
                count++;

                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[i] > shotTarget)
                    {
                        targets[i] -= shotTarget;
                    }
                    else if (targets[i] <= shotTarget && targets[i] != -1)
                    {
                        targets[i] += shotTarget;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {count} -> {string.Join(' ', targets)}");
        }
    }
}
