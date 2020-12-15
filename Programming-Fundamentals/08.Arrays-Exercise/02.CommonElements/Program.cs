using System;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split();
            string[] array2 = Console.ReadLine().Split();

            foreach (string elementTwo in array2)        //щеше да е същото с още един фор цикъл for (int i = 0; i <                                                                                                             array2.Lenght; i++)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (elementTwo == array1[i])
                    {
                        Console.Write(elementTwo + " ");
                    }
                }
            }
        }
    }
}
