using System;
using System.Text;

namespace _04.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string command = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            while (command != "Done")
            {
                string[] cmdArgs = command.Split();
                string commands = cmdArgs[0];

                switch (commands)
                {
                    case "TakeOdd":

                        for (int i = 1; i < password.Length; i += 2)
                        {
                            sb.Append(password[i]);
                        }

                        password = sb.ToString();
                        Console.WriteLine(password);
                        break;

                        case "Cut":
                        int index = int.Parse(cmdArgs[1]);
                        int lenght = int.Parse(cmdArgs[2]);

                        password = password.Remove(index, lenght);
                        Console.WriteLine(password);
                        break;

                        case "Substitute":
                        string substring = cmdArgs[1];
                        string substitute = cmdArgs[2];

                        if (password.Contains(substring))
                        {
                            password = password.Replace(substring, substitute);
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
