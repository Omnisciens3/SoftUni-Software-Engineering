using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> pumps = new Queue<string>();

            for (int i = 0; i < n; i++)
            {
                pumps.Enqueue(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                int currentFuel = 0;
                bool isSuccessfull = true;

                for (int j = 0; j < n; j++)
                {
                    string pumpDataStr = pumps.Dequeue();
                    int[] pumpData = pumpDataStr.Split().Select(int.Parse).ToArray();
                    pumps.Enqueue(pumpDataStr);

                    currentFuel += pumpData[0];
                    currentFuel -= pumpData[1];

                    if (currentFuel < 0)
                    {
                        isSuccessfull = false;
                    }
                } 

                if (isSuccessfull)
                {
                    Console.WriteLine(i);
                    break;
                }

                string tempData = pumps.Dequeue();
                pumps.Enqueue(tempData);
                GC.Collect();
            }
        }
    }
}
