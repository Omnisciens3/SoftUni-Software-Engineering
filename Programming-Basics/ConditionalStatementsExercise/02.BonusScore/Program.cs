using System;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int initialScore = int.Parse(Console.ReadLine());
            double bonus = 0.0;
            if (initialScore <= 100)
            {
                bonus =  5;
            }
            else if (initialScore > 1000)
            {
                bonus = initialScore * 0.1;
            }
            else
            {
                bonus = initialScore * 0.2;
            }
            
            if (initialScore % 2 == 0)
            {
                bonus += 1;
            }
            else if (initialScore % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(initialScore + bonus);
        }
    }
}
