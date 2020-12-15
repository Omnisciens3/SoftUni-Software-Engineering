using System;
using System.Linq;

namespace _03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                //if (arr[i] == 0) // правим проверка в случай, че ни зададат -0 като инпут
                //{
                //    arr[i] = 0;  - това не сработи...
                //}
                Console.WriteLine($"{Convert.ToDecimal(arr[i])} => {Math.Round(Convert.ToDecimal(arr[i]), MidpointRounding.AwayFromZero)}"); // явно се нуждаем от много голяма точност, затова трябва да конвертираме в децимал.
            }
        }
    }
}
