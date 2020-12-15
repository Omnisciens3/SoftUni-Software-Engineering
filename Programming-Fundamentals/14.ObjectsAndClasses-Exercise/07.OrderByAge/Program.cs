using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (input != "End")
            {
                string[] cmdArgs = input.Split();
                string name = cmdArgs[0];
                int id = int.Parse(cmdArgs[1]);
                int age = int.Parse(cmdArgs[2]);

                Student currentStudent = new Student(name, id, age);

                students.Add(currentStudent);

                input = Console.ReadLine();
            }

            students = students.OrderBy(x => x.Age).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, students));
        }
    }

    class Student
    {
        public Student(string name, int iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }

    }
}
