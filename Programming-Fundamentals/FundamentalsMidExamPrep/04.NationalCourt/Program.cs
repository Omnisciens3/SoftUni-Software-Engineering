using System;

namespace _04.NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeOneEff = int.Parse(Console.ReadLine());
            int employeeTwoEff = int.Parse(Console.ReadLine());
            int employeeThreeEff = int.Parse(Console.ReadLine());
            int customers = int.Parse(Console.ReadLine());

            int hourCount = 0;

            int allEmployeesEff = employeeOneEff + employeeTwoEff + employeeThreeEff;

            while (customers > 0)
            {
                hourCount++;

                if (hourCount % 4 == 0)
                {
                    continue;
                }

                customers -= allEmployeesEff;
            }

            Console.WriteLine($"Time needed: {hourCount}h.");
        }
    }
}
