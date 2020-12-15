using System;

namespace _06.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

             int facebookFine = 150;
             int instagramFine = 100;
             int redditFine = 50;

            for (int i = 0; i <= n; i++)
            {
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
                string website = Console.ReadLine();
                if (website == "Facebook")
                {
                    salary -= facebookFine;
                }
                else if (website == "Instagram")
                {
                    salary -= instagramFine;
                }
                else if (website == "Reddit")
                {
                    salary -= redditFine;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
