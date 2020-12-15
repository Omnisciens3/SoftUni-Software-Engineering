using System;

namespace _05.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());

            for (int i = start; i <= finish; i++)
            {
                char symbol = (char)i;
                Console.Write(symbol + " ");
                //Console.Write($"{(char)i} "); - по-кратко решение -> кастваме чар към ай
            }
        }
    }
}
