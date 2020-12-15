using System;

namespace _07.ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string delimitier = Console.ReadLine();

            Console.WriteLine($"{name1}{delimitier}{name2}");
        }
    }
}
