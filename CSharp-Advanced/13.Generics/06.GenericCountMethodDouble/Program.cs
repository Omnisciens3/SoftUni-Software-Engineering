using System;
using System.Collections.Generic;

namespace _06.GenericCountMethodDouble
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<double>> doubles = new List<Box<double>>();

            for (int i = 0; i < n; i++)
            {
                Box<double> number = new Box<double>(double.Parse(Console.ReadLine()));
                doubles.Add(number);
            }

            double value = double.Parse(Console.ReadLine());
            Box<double> comparableBox = new Box<double>(value);

            int count = GetGreater(doubles, comparableBox);
            Console.WriteLine(count);

        }
        private static int GetGreater<T>(List<Box<T>> boxes, Box<T> box) where T : IComparable
        {
            int count = 0;

            foreach (Box<T> item in boxes)
            {
                if (item.Value.CompareTo(box.Value) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
