using System;
using System.Collections.Generic;
using System.Linq;

namespace DateModifierProblem
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            int days = DateModifier.GetDiffBetweenDates(firstDate, secondDate);

            Console.WriteLine(Math.Abs(days));
        }
    }
}
