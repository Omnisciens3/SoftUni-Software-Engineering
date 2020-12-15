using System;

namespace EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfColoredEggs = int.Parse(Console.ReadLine());
            int red = 0;
            int orange = 0;
            int blue = 0;
            int green = 0;
            int maxEggs = int.MinValue;
            string col = "";

            for (int eggs = 1; eggs <= numberOfColoredEggs; eggs++)
            {
                string colour = Console.ReadLine();
                if (colour == "red")
                {
                    red++;
                    col = "red";
                }
                else if (colour == "orange")
                {
                    orange++;
                    col = "orange"; 
                }
                else if (colour == "blue")
                {
                    blue++;
                    col = "blue";
                }
                else if (colour == "green")
                {
                    green++;
                    col = "green";
                }
            }
            if (maxEggs < red)
            {
                maxEggs = red;
            }
            else if (maxEggs < orange)
            {
                maxEggs = orange;
            }
            else if (maxEggs < blue)
            {
                maxEggs = blue;
            }
            else
            {
                maxEggs = green;
            }
            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: {orange}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Green eggs: {green}");
            Console.WriteLine($"Max eggs: {maxEggs} -> {col}");
        }
    }
}
