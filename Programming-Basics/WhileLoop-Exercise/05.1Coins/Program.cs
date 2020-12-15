using System;

namespace _05._1Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            double convert = change * 100;
            int cent = (int)convert;
            int coins = 0;

            int reminder = cent % 200;
            coins += cent / 200;
            cent = reminder;

            reminder = cent % 100;
            coins += cent / 100;
            cent = reminder;

            reminder = cent % 50;
            coins += cent / 50;
            cent = reminder;

            reminder = cent % 20;
            coins += cent / 20;
            cent = reminder;

            reminder = cent % 10;
            coins += cent / 10;
            cent = reminder;

            reminder = cent % 5;
            coins += cent / 5;
            cent = reminder;

            reminder = cent % 2;
            coins += cent / 2;
            cent = reminder;

            reminder = cent % 1;
            coins += cent / 1;
            cent = reminder;

            Console.WriteLine(coins);
        }
    }
}
