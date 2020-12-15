using System;

namespace _3.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\");
            string separate = input[input.Length - 1];
            string[] sepArgs = separate.Split(".");
            string fileName = sepArgs[0];
            string extension = sepArgs[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
