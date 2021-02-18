using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> bombEffects = new Queue<int>(Console.ReadLine()
                                                           .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                                           .Select(int.Parse)
                                                           .ToArray());

            Stack<int> bombCasings = new Stack<int>(Console.ReadLine()
                                                           .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                                           .Select(int.Parse)
                                                           .ToArray());

            int daturaCount = 0;
            int cherryCount = 0;
            int smokeCount = 0;
            bool isFilled = false;

            while (bombEffects.Count > 0 && bombCasings.Count > 0)
            {
                int effect = bombEffects.Dequeue();
                int casing = bombCasings.Pop();
                int sum = effect + casing;

                if (sum == 40)
                {
                    daturaCount++;
                }
                else if (sum == 60)
                {
                    cherryCount++;
                }
                else if (sum == 120)
                {
                    smokeCount++;
                }
                else
                {
                    while (true)
                    {
                        casing -= 5;

                        sum = effect + casing;

                        if (sum == 40)
                        {
                            daturaCount++;
                            break;
                        }
                        else if (sum == 60)
                        {
                            cherryCount++;
                            break;
                        }
                        else if (sum == 120)
                        {
                            smokeCount++;
                            break;
                        }
                    }
                }

                if (daturaCount >= 3 && cherryCount >= 3 && smokeCount >= 3)
                {
                    isFilled = true;
                    break;
                }
            }

            if (isFilled)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffects.Count > 0)
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffects)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (bombCasings.Count > 0)
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasings)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            Console.WriteLine($"Cherry Bombs: {cherryCount}");
            Console.WriteLine($"Datura Bombs: {daturaCount}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeCount}");
        }
    }
}
