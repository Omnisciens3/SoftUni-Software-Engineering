using System;
using System.Linq;

namespace _04._1.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = new string[rows, cols];

            ReadMatrix(matrix);

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] cmdArgs = command.Split();
                string cmnd = cmdArgs[0];

                if (cmdArgs.Length != 5 || cmnd != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }

                int row1 = int.Parse(cmdArgs[1]);
                int col1 = int.Parse(cmdArgs[2]);
                int row2 = int.Parse(cmdArgs[3]);
                int col2 = int.Parse(cmdArgs[4]);

                bool isValidOne = IsValidCell(row1, col1, rows, cols);
                bool isValidTwo = IsValidCell(row2, col2, rows, cols);

                if (!isValidOne || !isValidTwo)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    string valueOne = matrix[row1, col1];
                    string valueTwo = matrix[row2, col2];

                    matrix[row1, col1] = valueTwo;
                    matrix[row2, col2] = valueOne;

                    PrintMatrix(matrix);
                }
                command = Console.ReadLine();
            }
        }

        private static void ReadMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool IsValidCell(int row, int col, int rows, int cols)
        {
            return row >= 0 && row < rows && col >= 0 && col < cols;
        }
    }
}
