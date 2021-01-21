using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] rowData = Console.ReadLine().Split();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

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

                bool isValidOne = row1 >= 0 && row1 < rows && col1 >= 0 && col1 < cols;
                bool isValidTwo = row2 >= 0 && row2 < rows && col2 >= 0 && col2 < cols;

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

                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}

