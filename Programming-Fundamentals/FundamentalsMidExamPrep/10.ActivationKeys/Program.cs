using System;

namespace _10.SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());

            int students = int.Parse(Console.ReadLine());

            int hours = 0;

            int employeesEff = employee1 + employee2 + employee3;

            while (students > 0)
            {
                hours++;

                if (hours % 4 == 0)
                {
                    hours++;
                }

                students -= employeesEff;
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
