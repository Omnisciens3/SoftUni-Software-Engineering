using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBadScoresAcceptable = int.Parse(Console.ReadLine());
            string nameOfTheTask = Console.ReadLine();

            int badScoreCount = 0;
            int numberOfTasks = 0;
            int totalScore = 0;
            string lastProblemSolved = "";
            bool isPerfect = true;

            while (nameOfTheTask != "Enough")
            {
                int score = int.Parse(Console.ReadLine());
                lastProblemSolved = nameOfTheTask;
                numberOfTasks++;
                totalScore += score;
                if (score <= 4)
                {
                    badScoreCount++;
                    if (badScoreCount >= numberOfBadScoresAcceptable)
                    {
                        isPerfect = false;
                        break;
                    }
                }
                nameOfTheTask = Console.ReadLine();
            }
            if (isPerfect)
            {
                double averageScore = 1.0 * totalScore / numberOfTasks;
                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {numberOfTasks}");
                Console.WriteLine($"Last problem: {lastProblemSolved}");
            }
            else
            {
                Console.WriteLine($"You need a break, {badScoreCount} poor grades.");
            }
        }
    }
}
