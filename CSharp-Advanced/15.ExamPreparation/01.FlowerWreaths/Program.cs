using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine()
                                                      .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                                      .Select(int.Parse)
                                                      .ToArray());

            Queue<int> roses = new Queue<int>(Console.ReadLine()
                                                      .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                                      .Select(int.Parse)
                                                      .ToArray());

            int wreaths = 0;
            int extraFlowers = 0;

            while (lilies.Count > 0 && roses.Count > 0)
            {
                int currentRose = roses.Dequeue();
                int currentLillie = lilies.Pop();

                int sum = currentRose + currentLillie;

                if (sum == 15)
                {
                    wreaths++;
                }
                else if (sum > 15)
                {
                    while (true)
                    {
                        sum -= 2;
                        if (sum == 15)
                        {
                            wreaths++;
                            break;
                        }
                        if (sum < 15)
                        {
                            extraFlowers += sum;
                            break;
                        }
                    }
                }
                else
                {
                    extraFlowers += sum;
                }
            }

            wreaths += extraFlowers / 15;

            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
            }
        }
    }
}
