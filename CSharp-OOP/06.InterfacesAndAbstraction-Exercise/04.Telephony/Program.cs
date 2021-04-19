using System;
using System.Linq;

namespace _04.Telephony
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] websites = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Smartphone smartphone = new Smartphone();

            StationaryPhone stationary = new StationaryPhone();

            foreach (var number in phoneNumbers)
            {
                try
                {
                    string result = number.Length == 10 ? smartphone.Call(number) : stationary.Call(number);

                    Console.WriteLine(result);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var url in websites)
            {
                try
                {
                    string result = smartphone.Browse(url);

                    Console.WriteLine(result);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
