using System;
using System.Text;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());

            RepeatString(input, repeatCount);
        }

        private static void RepeatString(string str, int repeats)
        {
            StringBuilder repeat = new StringBuilder();

            for (int i = 0; i < repeats; i++)
            {
                repeat.Append(str);
            }

            Console.WriteLine(repeat);
        }
    }
}
