using System;
using System.Linq;

namespace _01._DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());

            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int primaryDiagonal = 0;
            int counter = sizeOfMatrix - 1;
            int secondaryDiagonal = 0;

            for (int row = 0; row < sizeOfMatrix; row++)
            {
                primaryDiagonal += matrix[row, row]; //вместо с 2 вложени фор-цикъла.
                secondaryDiagonal += matrix[row, counter];
                counter--;
            }

            int difference = Math.Abs(primaryDiagonal - secondaryDiagonal);
            Console.WriteLine(difference);
        }
    }
}
