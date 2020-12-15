using System;

namespace Literature
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input

            int pages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            // Calc

            double totalTime = pages / pagesPerHour;
            double hoursPerDay = totalTime / days;

            //Output

            Console.WriteLine(hoursPerDay);

        }
    }
}
