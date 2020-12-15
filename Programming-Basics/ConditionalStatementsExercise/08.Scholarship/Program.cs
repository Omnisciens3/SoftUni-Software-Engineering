using System;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageScore = double.Parse(Console.ReadLine());
            double minimalWage = double.Parse(Console.ReadLine());

            double socialScholarship = Math.Floor(minimalWage * 0.35);
            double excellentScholarship = Math.Floor(averageScore * 25);
            //Social
            if (income >= minimalWage && averageScore >= 5.5)
            {

                Console.WriteLine($"You get a scholarship for excellent results {excellentScholarship} BGN");
            }
            else if (income >= minimalWage && averageScore < 5.5)
            {
                Console.WriteLine("You cannot get a scholarship!");

            }
            else if (income < minimalWage && averageScore >= 5.5 && socialScholarship <= excellentScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellentScholarship} BGN");
            }
            else if (income < minimalWage && averageScore <= 4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (income < minimalWage && averageScore > 4.5)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
        }
    }
}
