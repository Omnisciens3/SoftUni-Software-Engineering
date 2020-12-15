using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            CharactersBetween(start, end);
        }

        private static void CharactersBetween(char start, char end)
        {
            if (start > end)
            {
                char firstChar = start;
                start = end;
                end = firstChar;
            }

            for (int i = start + 1; i < end; i++)
            {
                //Console.Write((Convert.ToChar(i)).ToString() + " ");
                Console.Write((char)i + " ");
            }
        }
    }
}
