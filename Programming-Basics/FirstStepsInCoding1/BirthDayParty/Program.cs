using System;

namespace BirthDayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input

            double hallRent = double.Parse(Console.ReadLine());

            //Calc

            double cake = hallRent * 20 / 100;
            double drinks = cake - (0.45 * cake);
            double animator = hallRent / 3;
            double totalSum = hallRent + cake + drinks + animator;



            //Output

            Console.WriteLine(totalSum);

        }
    }
}
