﻿using System;

namespace _11.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {(lenght * width * height) / 3:f2}");
        }
    }
}
