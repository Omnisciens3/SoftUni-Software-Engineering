using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)numberOfPeople / capacityOfElevator); // използваме Math.Ceiling, за да можем да закръглим нагоре. Ако след делението на броя на хората и капацитета на асансьора получим дробно число, например имаме 5.5 човека спрямо капацитета на асансьора (5) - са ни необходими 3 курса, защото имаме 11 човек
            Console.WriteLine(courses);
        }
    }
}
