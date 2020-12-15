﻿using System;

namespace _08.OnTimefortheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minuteOfExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minuteOfArrival = int.Parse(Console.ReadLine());

            int difference = 0;
            int hour = 0;
            int minutes = 0;

            minuteOfExam += hourOfExam * 60;
            minuteOfArrival += hourOfArrival * 60;

            if (minuteOfArrival > minuteOfExam)
            {
                Console.WriteLine("Late");
                difference = minuteOfArrival - minuteOfExam;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours after the start");
                }
            }
            else if (minuteOfArrival < minuteOfExam - 30)
            {
                difference = minuteOfExam - minuteOfArrival;
                Console.WriteLine("Early");
                if (difference < 60)
                {
                    
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours before the start");
                }
            }
            else if (minuteOfArrival <= minuteOfExam)
            {
                
                difference = minuteOfExam - minuteOfArrival;
                Console.WriteLine("On time");
                if (difference <= 30)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }

            }
        }
    }
}
