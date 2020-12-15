using System;

namespace _04.SumОfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= numberOfLines; i++)
            {
                char input = char.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
