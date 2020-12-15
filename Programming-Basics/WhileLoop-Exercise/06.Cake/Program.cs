using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int cakePieces = lenght * width;

            while (true)
            {
                string cmd = Console.ReadLine();
                if (cakePieces <= 0 || cmd == "STOP")
                {
                    break;
                }
                int cake = int.Parse(cmd);
                cakePieces -= cake;
            }
            if (cakePieces >= 0)
            {
                Console.WriteLine($"{cakePieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
            }
        }
    }
}
