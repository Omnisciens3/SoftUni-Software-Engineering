using System;
using System.Text;

namespace _01.TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] instructions = command.Split("|");
                string operations = instructions[0];

                switch (operations)
                {
                    case "Move":

                        int numberOfLetters = int.Parse(instructions[1]);
                        string copy = encryptedMessage.Substring(0, numberOfLetters);
                        encryptedMessage = encryptedMessage.Remove(0, numberOfLetters);
                        encryptedMessage += copy;

                        break;

                    case "Insert":

                        int index = int.Parse(instructions[1]);
                        string value = instructions[2];
                        encryptedMessage = encryptedMessage.Insert(index, value);

                        break;

                    case "ChangeAll":

                        string substring = instructions[1];
                        string replacement = instructions[2];

                        foreach (var item in encryptedMessage)
                        {
                            encryptedMessage = encryptedMessage.Replace(substring, replacement);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
