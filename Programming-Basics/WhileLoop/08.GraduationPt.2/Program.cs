using System;

namespace _08.GraduationPt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            double averageGrade = 0;
            int excluded = 0;
            while (grade <= 12)
            {
                if (excluded == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {grade} grade");
                    Environment.Exit(0);
                    
                }
                double grades = double.Parse(Console.ReadLine());
                if (grades < 4)
                {
                    excluded++;
                    continue;
                }
                averageGrade += grades;
                grade++;
            }   
            double averageTotal = averageGrade / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averageTotal:f2}");
        }
    }
}
