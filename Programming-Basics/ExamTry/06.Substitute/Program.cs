using System;

namespace _06.Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int counterSubs = 0;
            for (int i = k; i <= 8; i++)
            {
                for (int j = 9; j >= l; j--)
                {
                    for (int o = m; o <= 8; o++)
                    {
                        for (int u = 9; u >= n; u--)
                        {
                            if (i % 2 == 0 && j % 2 != 0 && o % 2 == 0 && u % 2 != 0)
                            {
                                if (i == o && j == u)
                                {
                                    Console.WriteLine("Cannot change the same player.");
                                }
                                else
                                {
                                    Console.WriteLine($"{i}{j} - {o}{u}");
                                    counterSubs++;
                                }
                            }
                            if (counterSubs == 6)
                            {
                                break;
                            }
                        }
                        if (counterSubs == 6)
                        {
                            break;
                        }
                    }
                    if (counterSubs == 6)
                    {
                        break;
                    }
                }
                if (counterSubs == 6)
                {
                    break;
                }
            }
        }
    }
}
