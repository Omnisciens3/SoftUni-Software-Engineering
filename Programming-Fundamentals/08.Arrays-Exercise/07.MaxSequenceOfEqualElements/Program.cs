using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxCount = 0;
            int count = 1; // защото започваме от i = 1;
            int start = 0; // това ще ни даде началото на масива откъдето започваме да получаваме еднакви стойности. Стартовия индекс.
            int bestStart = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1]) //понеже започваме с i = 1 сравняваме с предния елемент i - 1; 
                {
                    count++;
                }
                else
                {
                    count = 1;
                    start = i;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    bestStart = start;
                }
            }

            for (int i = bestStart; i < bestStart + maxCount; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
