using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isValidLenght = PasswordLenght(password);
            bool isLettersAndDigits = PassLettersDigits(password);
            bool isTwoDigited = PassHasTwoDigits(password);

            if (isValidLenght && isLettersAndDigits && isTwoDigited)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!PasswordLenght(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!PassLettersDigits(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!PassHasTwoDigits(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        private static bool PassHasTwoDigits(string password)
        {
            int digitsCounter = 0;

            foreach (char digit in password)
            {
                if (char.IsDigit(digit))
                {
                    digitsCounter++;
                }
            }

            if (digitsCounter >= 2)
            {
                return true;
            }

            return false;
        }

        private static bool PassLettersDigits(string password)
        {
            foreach (char character in password)
            {
                if (!char.IsLetterOrDigit(character))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool PasswordLenght(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }

            return false;
        }
    }
}
