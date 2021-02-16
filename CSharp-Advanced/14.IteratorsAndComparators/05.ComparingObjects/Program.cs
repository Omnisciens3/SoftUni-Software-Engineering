using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] inputData = input.Split();
                string name = inputData[0];
                int age = int.Parse(inputData[1]);
                string town = inputData[2];

                people.Add(new Person(name, age, town));

                input = Console.ReadLine();
            }

            int equalPeopleCount = 0;
            int notEqualPeopleCount = 0;

            int personIndex = int.Parse(Console.ReadLine());

            Person targetPerson = people[personIndex - 1];

            foreach (Person person in people)
            {
                if (person.CompareTo(targetPerson) == 0)
                {
                    equalPeopleCount++;
                }
                else
                {
                    notEqualPeopleCount++;
                }
            }

            if (equalPeopleCount > 1)
            {
                Console.WriteLine($"{equalPeopleCount} {notEqualPeopleCount} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
