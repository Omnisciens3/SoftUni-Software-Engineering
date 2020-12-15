﻿using System;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                                  .Split();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string elementToRotate = arr[0]; // от 0-ла, защото винаги взимаме 1вия елемент.
                for (int j = 1; j < arr.Length; j++)
                {
                    string currentElement = arr[j];
                    arr[j - 1] = currentElement;
                }
                arr[arr.Length - 1] = elementToRotate;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
