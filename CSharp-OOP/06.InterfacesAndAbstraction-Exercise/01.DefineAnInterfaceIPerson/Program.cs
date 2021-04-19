using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IIdentifiable> identifiables = new List<IIdentifiable>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] parts = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 3)
                {
                    string name = parts[0];
                    int age = int.Parse(parts[1]);
                    string id = parts[2];

                    Citizen citizen = new Citizen(name, age, id);

                    identifiables.Add(citizen);
                }

                if (parts.Length == 2)
                {
                    string model = parts[0];
                    string id = parts[1];

                    Robot robot = new Robot(model, id);

                    identifiables.Add(robot);
                }
            }

            string fakeEnd = Console.ReadLine();

            List<IIdentifiable> filtered = identifiables.Where(i => i.Id.EndsWith(fakeEnd)).ToList();

            foreach (var fake in filtered)
            {
                Console.WriteLine(fake.Id);
            }
        }
    }
}
