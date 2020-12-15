using System;

namespace _01.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int totalTime = 0;
            totalTime += int.Parse(Console.ReadLine());
            totalTime += int.Parse(Console.ReadLine());
            totalTime += int.Parse(Console.ReadLine());
            //Calculations
            int minutes = totalTime / 60; //делим на 60, за да получим минути от секунди
            int seconds = totalTime % 60; //модулно деление, за да получим остатъка от секундите, които не правят цяла минута
            //Output
            Console.WriteLine($"{minutes}:{seconds:d2}");  //d2 - decimal formatting - за да покаже хх:00 - закръгля с прецизна точност
            
        }
    }
}
