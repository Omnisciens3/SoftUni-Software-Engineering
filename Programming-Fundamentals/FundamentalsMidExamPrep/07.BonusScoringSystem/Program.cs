using System;

namespace _07.BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            int countOfLectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());
                        
            int bestStudent = 0;
            double bestOfBest = 0;

            for (int i = 0; i < countOfStudents; i++)
            {
                int currentStudent = int.Parse(Console.ReadLine());

                double totalBonus = currentStudent / (countOfLectures * 1.0) * (5 + additionalBonus);
                               
                if (bestOfBest < totalBonus)
                {
                    bestOfBest = totalBonus;
                    bestStudent = currentStudent;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(bestOfBest)}.");
            Console.WriteLine($"The student has attended {bestStudent} lectures.");
        }
    }
}
