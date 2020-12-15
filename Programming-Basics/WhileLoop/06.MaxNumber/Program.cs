using System;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int maxNum = int.MinValue;

            while (command != "Stop")
            {
                int num = int.Parse(command);
                
                if (maxNum < num)
                {
                    maxNum = num;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(maxNum);
        }
    }
}
