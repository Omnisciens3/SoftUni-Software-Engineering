﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] personData = Console.ReadLine().Split();

                string name = personData[0];
                int age = int.Parse(personData[1]);

                Person currentPerson = new Person(name, age);

                people.Add(currentPerson);
            }

            List<Person> filteredPeople = people.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();

            foreach (Person person in filteredPeople)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}