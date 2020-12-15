using System;

namespace _01.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int[] array = new int[] { num1, num2, num3 };
            Array.Sort(array); // подрежда числата във възходящ ред
            Array.Reverse(array); // обръща подредените числа от възходящ в низходящ ред
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }
    }
}
