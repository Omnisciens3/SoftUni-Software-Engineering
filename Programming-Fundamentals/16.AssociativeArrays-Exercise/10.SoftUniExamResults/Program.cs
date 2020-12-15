using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                string[] cmdArgs = input.Split("-");
                string username = cmdArgs[0];

                if (cmdArgs.Length > 2)
                {
                    string language = cmdArgs[1];
                    int points = int.Parse(cmdArgs[2]);

                    if (!students.ContainsKey(username))
                    {
                        students.Add(username, points);
                    }
                    else
                    {
                        if (students[username] < points)
                        {
                            students[username] = points;
                        }
                    }

                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 0);
                    }

                    submissions[language]++;
                }
                else
                {
                    students.Remove(username);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");

            foreach (var currentStudent in students.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{currentStudent.Key} | {currentStudent.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var currentSubmissions in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{currentSubmissions.Key} - {currentSubmissions.Value}");
            }
        }
    }
}
