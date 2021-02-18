using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = dimensions[0];
            int m = dimensions[1];

            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = 0;
                }
            }

            string input = Console.ReadLine();

            while (input != "Bloom Bloom Plow")
            {
                int[] coordinates = input.Split().Select(int.Parse).ToArray();
                int flowerRow = coordinates[0];
                int flowerCol = coordinates[1];

                if (!IsPositionValid(flowerRow, flowerCol, n, m))
                {
                    Console.WriteLine("Invalid coordinates.");
                    input = Console.ReadLine();
                    continue;
                }

                matrix[flowerRow, flowerCol]++;

                input = Console.ReadLine();
            }

            Queue<int> firstFlowers = new Queue<int>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 1)
                    {
                        firstFlowers.Enqueue(row);
                        firstFlowers.Enqueue(col);
                    }
                }
            }

            while (firstFlowers.Count > 0)
            {
                int rowPosition = firstFlowers.Dequeue();
                int colPosition = firstFlowers.Dequeue();
                //down
                for (int row = rowPosition + 1; row < matrix.GetLength(0); row++)
                {
                    matrix[row, colPosition]++;
                }
                //up 
                for (int row = rowPosition - 1; row >= 0; row--)
                {
                    matrix[row, colPosition]++;
                }
                //right
                for (int col = colPosition + 1; col < matrix.GetLength(1); col++)
                {
                    matrix[rowPosition, col]++;
                }
                //left
                for (int col = colPosition - 1; col >= 0; col--)
                {
                    matrix[rowPosition, col]++;
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        public static bool IsPositionValid(int row, int col, int rows, int cols)
        {
            if (row < 0 || row >= rows)
            {
                return false;
            }
            if (col < 0 || col >= cols)
            {
                return false;
            }
            return true;
        }
    }
}
