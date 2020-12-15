using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); //power
            int M = int.Parse(Console.ReadLine()); //distance
            int Y = int.Parse(Console.ReadLine()); //exhaustion factor

            int originalN = N;
            int pokeCount = 0;

            while (N >= M)
            {
                N -= M;
                pokeCount++;

                if (N == originalN / 2 && Y != 0)
                {
                    N /= Y;
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(pokeCount);
        }
    }
}
