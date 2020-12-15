using System;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (char c in input)
            {
                char currentChar = (char)(c + 3);
                Console.Write(currentChar);
            }
        }
    }
}
