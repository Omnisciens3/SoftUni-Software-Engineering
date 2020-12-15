using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputArgs = input.Split();
                string firstName = inputArgs[0];
                string lastName = inputArgs[1];
                int age = int.Parse(inputArgs[2]);
                string hometown = inputArgs[3];

                Student currentStudent = new Student(firstName, lastName, age, hometown);

                //currentStudent.FirstName = firstName;
                //currentStudent.LastName = lastName;
                //currentStudent.Age = age;
                //currentStudent.HomeTown = hometown;

                students.Add(currentStudent);


                input = Console.ReadLine();
            }

            string nameOfACity = Console.ReadLine();

            List<Student> chosenStudents = students.Where(x => x.HomeTown == nameOfACity).ToList();

            foreach (Student student in chosenStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
