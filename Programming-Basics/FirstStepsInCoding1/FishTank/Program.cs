using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input

            int lenghtCm = int.Parse(Console.ReadLine());
            int widthCm = int.Parse(Console.ReadLine());
            int hightCm = int.Parse(Console.ReadLine());
            double percentageFull = double.Parse(Console.ReadLine());

            //Calc

            int volume = lenghtCm * widthCm * hightCm;
            double litres = volume * 0.001;
            double percentage = percentageFull * 0.01;
            double litresNeeded = litres * (1 - percentage);


            //Output
            Console.WriteLine(litresNeeded);
        }
    }
}
