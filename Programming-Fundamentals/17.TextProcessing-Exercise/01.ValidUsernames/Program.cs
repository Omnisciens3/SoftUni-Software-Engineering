using System;
using System.Linq;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string currentUsername = string.Empty;
            bool isValid = false;
            
            for (int i = 0; i < usernames.Length; i++)
            {
                currentUsername = usernames[i];

                if (currentUsername.Length > 3 && currentUsername.Length < 16)
                {
                    foreach (char ch in currentUsername)
                    {
                        if (currentUsername.All(c => char.IsLetterOrDigit(c)) 
                                                                             || currentUsername.Contains("-") 
                                                                             || currentUsername.Contains("_"))
                        {
                            isValid = true;
                        }
                    }
                }

                if (isValid)
                {
                    Console.WriteLine(currentUsername);
                }

                isValid = false;
            }
        }
    }
}
