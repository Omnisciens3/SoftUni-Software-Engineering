using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<ICommon> commons = new List<ICommon>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string type = parts[0];

                if (type == nameof(Citizen))
                {
                    string name = parts[1];
                    int age = int.Parse(parts[2]);
                    string id = parts[3];
                    string birthdate = parts[4];

                    commons.Add(new Citizen(name, age, id, birthdate));
                }
                else if (type == nameof(Pet))
                {
                    string name = parts[1];
                    string birthdate = parts[2];

                    commons.Add(new Pet(name, birthdate));
                }
            }

            string year = Console.ReadLine();
            List<ICommon> filtered = commons.Where(b => b.Birthdate.EndsWith(year)).ToList();

            foreach (var item in filtered)
            {
                Console.WriteLine(item.Birthdate);
            }
        }
    }
}
