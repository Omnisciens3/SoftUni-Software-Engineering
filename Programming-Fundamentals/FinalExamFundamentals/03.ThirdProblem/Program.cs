using System;
using System.Collections.Generic;
using System.Text;

namespace _03.ThirdProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> peoples = new List<People>();

            string command = Console.ReadLine();

            while (command != "Results")
            {
                string[] tokens = command.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];
                string name = tokens[1];

                switch (cmd)
                {
                    case "Add":
                        int health = int.Parse(tokens[2]);
                        int energy = int.Parse(tokens[3]);

                        People person = new People() { Name = name, Health = health, Energy = energy };

                        if (peoples.Contains(person))
                        {
                            person.Health += health;
                            person.Energy += energy;
                        }
                        else
                        {
                            peoples.Add(person);
                        }
                        break;

                        case "Attack":
                        string defenderName = tokens[2];
                        int damage = int.Parse(tokens[3]);
                        person.Name 
                        if (peoples.Contains()
                        {

                        }
                        break;
                        case "Delete":
                        break;

                }
            }
        }
    }

    class People
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Energy { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Name} - {Health} - {Energy}");

            return sb.ToString();
        }
    }
}
