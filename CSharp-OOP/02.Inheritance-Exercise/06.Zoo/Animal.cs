using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public virtual string ProduceSound() //правим го virtual, за да можем да го override-нем в подкласовете
        {
            return string.Empty;
        }

        public override string ToString()
        {
            return GetType().Name + Environment.NewLine + $"{Name} {Age} {Gender}";
        }

    }
}
