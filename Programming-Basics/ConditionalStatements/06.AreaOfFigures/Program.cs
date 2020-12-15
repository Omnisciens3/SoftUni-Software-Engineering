using System;

namespace _06.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")

            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a*a:F3}");
            }
            else if (figure == "triangle")

            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine($"{(a * b / 2):F3}"); ;

            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine($"{r * Math.PI * r:F3}");
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * b:F3}");

            }
        }
    }
}
