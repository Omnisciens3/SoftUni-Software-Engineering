using System;
using System.Security.Cryptography;

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Random rnd = new Random();
            int index = 0;

            for (int i = 0; i < words.Length; i++)
            {
                index = rnd.Next(words.Length);
                string word = words[i];
                words[i] = words[index];
                words[index] = word;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
