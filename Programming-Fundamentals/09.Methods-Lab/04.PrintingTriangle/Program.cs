using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            int start = 1;
            //PrintLine(start, end);
            PrintTriangle(start, end);
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintTriangle(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                PrintLine(start, i);
            }

            for (int i = end - start; i >= start; i--)
            {
                PrintLine(start, i);
            }
        }
    }
}
