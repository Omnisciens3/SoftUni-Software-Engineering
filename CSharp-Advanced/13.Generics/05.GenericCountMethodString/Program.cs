using System;
using System.Collections.Generic;

namespace _05.GenericCountMethodString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<string>> boxes = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());
                boxes.Add(box);
            }

            string value = Console.ReadLine();
            Box<string> comparableBox = new Box<string>(value);

            int count = GetGreater(boxes, comparableBox);
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
