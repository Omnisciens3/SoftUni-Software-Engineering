using System;
using System.Linq;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                Console.WriteLine(IsPalindrome(input).ToString().ToLower());
                input = Console.ReadLine();
            }
        }

        static bool IsPalindrome(string output)
        {
            var reversed = output.Reverse().ToArray();

            for (int i = 0; i < output.Length; i++)
            {
                if (!(reversed[i] == output[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
