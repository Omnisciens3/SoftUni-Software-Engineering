using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeopleInTheJury = int.Parse(Console.ReadLine());
            string nameOfThePresentation = Console.ReadLine();
            int gradesCount = 0;
            double sumOfAllGrades = 0;
            while (nameOfThePresentation != "Finish")
            {
                double gradeSum = 0;
                for (int i = 0; i < numberOfPeopleInTheJury; i++)
                {
                    double currentGrade = double.Parse(Console.ReadLine());
                    gradeSum += currentGrade;
                    gradesCount++;
                    sumOfAllGrades += currentGrade;
                }
                double averageGrade = gradeSum / numberOfPeopleInTheJury;
                Console.WriteLine($"{nameOfThePresentation} - {averageGrade:f2}.");
                nameOfThePresentation = Console.ReadLine();
            }
            double averageOfAllGrades = sumOfAllGrades / gradesCount;
            Console.WriteLine($"Student's final assessment is {averageOfAllGrades:f2}.");
        }
    }
}
