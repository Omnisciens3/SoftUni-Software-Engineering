﻿using System;
using System.Text;

namespace _05.Digits_LettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder other = new StringBuilder();

            foreach (char character in input)
            {
                if (char.IsDigit(character))
                {
                    digits.Append(character);
                }
                else if (char.IsLetter(character))
                {
                    letters.Append(character);
                }
                else
                {
                    other.Append(character);
                }
            }

            Console.WriteLine($"{digits}\n{letters}\n{other}");
        }
    }
}
