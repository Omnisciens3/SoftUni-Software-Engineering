using System;
using System.Linq;

namespace _08.Bombs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string[] coordinatesValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            ExplodeBombs(matrix, coordinatesValues);

            int aliveCells = 0;
            int sumAliveCells = 0;

            foreach (int cell in matrix)
            {
                if (cell > 0)
                {
                    aliveCells++;
                    sumAliveCells += cell;
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sumAliveCells}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        public static void ExplodeBombs(int[,] matrix, string[] coordinatesValues)
        {
            foreach (string rowColPair in coordinatesValues)
            {
                int[] currentBombCoordinates = rowColPair
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentBombRow = currentBombCoordinates[0];
                int currentBombCol = currentBombCoordinates[1];
                int currentBomb = matrix[currentBombRow, currentBombCol];

                for (int row = currentBombRow - 1; row <= currentBombRow + 1; row++)
                {
                    for (int col = currentBombCol - 1; col <= currentBombCol + 1; col++)
                    {
                        if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
                        {
                            if (matrix[row, col] <= 0 || currentBomb < 0)
                            {
                                continue;
                            }
                            matrix[row, col] -= currentBomb;
                        }

                    }

                }

            }
        }
    }
}
