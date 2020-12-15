using System;

namespace _10._Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                
            }
            else if (number > 200)
            {
                Console.WriteLine("invalid");
            }
            else if (number < 0)
            {
                Console.WriteLine("invalid");
            }
            else if (number < 100)
            {
                Console.WriteLine("invalid");
            }
            
        }
    }
}
