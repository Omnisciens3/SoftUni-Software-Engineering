﻿using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();
            bool isBigger = true;

            for (int i = 0; i < array.Length; i++)
            {
                int currentNum = array[i];

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] >= currentNum)
                    {
                        isBigger = false;
                    }
                }

                if (isBigger)
                {
                    Console.Write(currentNum + " ");
                }
                isBigger = true;
            }
        }
    }
}
