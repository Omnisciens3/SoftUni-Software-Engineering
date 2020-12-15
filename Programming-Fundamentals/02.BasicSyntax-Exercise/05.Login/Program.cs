using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            int countOfMistakes = 0;
            
            while (true)
            {
                string currentPassword = Console.ReadLine();

                if (currentPassword != password)
                {
                    countOfMistakes++;
                    
                    if (countOfMistakes == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        Environment.Exit(0);
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {username} logged in.");
                    Environment.Exit(0);
                }
            }
        }
    }
}
