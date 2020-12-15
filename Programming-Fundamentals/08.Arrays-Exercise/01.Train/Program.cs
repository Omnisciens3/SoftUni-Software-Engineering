using System;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] peopleInWagon = new int[numberOfWagons];
            int sum = 0;

            for (int i = 0; i < peopleInWagon.Length; i++)
            {
                peopleInWagon[i] = int.Parse(Console.ReadLine());
                sum += peopleInWagon[i];
            }
            //вместо да въвеждаме предварително празна променлива int sum = 0; и после да я добавяме във фор цикъла, можем направо след фор цикъла да запишем:
            // int sum = peopleInWagon.Sum(); - това е метод за масиви, който сумира всички елементи на масива.
            Console.WriteLine(string.Join(' ',peopleInWagon));
            Console.WriteLine(sum);
        }
    }
}
