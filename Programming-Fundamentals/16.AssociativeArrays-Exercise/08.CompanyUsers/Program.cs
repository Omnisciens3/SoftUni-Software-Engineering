using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArgs = command.Split(" -> ");
                string company = cmdArgs[0];
                string id = cmdArgs[1];

                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                }

                if (companies[company].Contains(id))
                {
                    command = Console.ReadLine();
                    continue;
                }

                companies[company].Add(id);

                command = Console.ReadLine();
            }

            foreach (var company in companies.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{company.Key}");

                foreach (var item in company.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
