using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
                    
            string[] array1 = new string[n];
            string[] array2 = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] currentArray = Console.ReadLine()
                                               .Split()
                                               .ToArray();

                string indexZeroElement = currentArray[0];
                string indexFirstElement = currentArray[1];

                if (i % 2 == 0)
                {
                    array1[i] = indexZeroElement;
                    array2[i] = indexFirstElement;
                }
                else if (i % 2 != 0)
                {
                    array1[i] = indexFirstElement;
                    array2[i] = indexZeroElement;
                }
            }
            Console.WriteLine(string.Join(" ", array1));
            Console.WriteLine(string.Join(" ", array2));
        }
    }
}
