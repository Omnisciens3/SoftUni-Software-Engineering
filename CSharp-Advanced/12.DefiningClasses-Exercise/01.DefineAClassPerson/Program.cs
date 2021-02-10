using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person personOne = new Person();
            personOne.Name = "Pesho";
            personOne.Age = 22;

            Person personTwo = new Person()
            {
                Name = "Kris",
                Age = 22
            };
        }
    }
}
