using System;

namespace _08._TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++) //Външен цикъл - изпълнява се отново, когато                                                          вътрешният се е изпълнил докрай
            {
                for (int j = 0; j < i; j++) //Изпълнява се докато условието е вярно j < i, после                                отново започва да се изпълнява външният цикъл
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
