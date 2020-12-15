using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string removeWord = Console.ReadLine();

            string words = Console.ReadLine();

            int index = words.IndexOf(removeWord);

            while (index != -1) //-1 означава, че нямаме такъв индекс повече.
            {
                words = words.Remove(index, removeWord.Length);

                index = words.IndexOf(removeWord);
            }

            Console.WriteLine(words);
        }
    }
}
