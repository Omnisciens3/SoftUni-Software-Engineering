using System;

namespace Farm
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            cat.Meow();
            cat.Eat();
            dog.Bark();
            dog.Eat();
        }
    }
}
