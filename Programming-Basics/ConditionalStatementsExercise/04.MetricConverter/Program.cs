using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string convertable = (Console.ReadLine());
            string converted = (Console.ReadLine());
            if (convertable == "mm" && converted == "m")
            {
                number /= 1000;
            }
            else if (convertable == "m" && converted == "mm")
            {
                number *= 1000;
            }
            else if (convertable == "m" && converted == "cm")
            {
                number *= 100;
            }
            else if (convertable == "cm" && converted == "m")
            {
                number /= 100;
            }
            else if (convertable == "cm" && converted == "mm")
            {
                number *= 10;
            }
            else if (convertable == "mm" && converted == "cm")
            {
                number /= 10;
            }

            Console.WriteLine($"{number:F3}");



        }
    }
}
