using System;

namespace _04.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int beggining = int.Parse(Console.ReadLine());
            int ending = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinationN = 0;

            bool flag = false;
            for (int i = beggining; i <= ending; i++)
            {
                for (int j = beggining; j <= ending; j++)
                {
                    combinationN++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinationN} ({i} + {j} = {magicNumber})");
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine($"{combinationN} combinations - neither equals {magicNumber}");
            }
        }
    }
}
