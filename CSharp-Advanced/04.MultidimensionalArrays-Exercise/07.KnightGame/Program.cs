using System;
using System.Linq;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfBoard = int.Parse(Console.ReadLine());

            char[,] matrix = new char[sizeOfBoard, sizeOfBoard];


            for (int row = 0; row < sizeOfBoard; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < sizeOfBoard; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int removedKnightsCount = 0;

            while (true)
            {
                int maxAttackedKnights = 0;
                int knightRow = -1;
                int knightCol = -1;

                for (int row = 0; row < sizeOfBoard; row++)
                {
                    for (int col = 0; col < sizeOfBoard; col++)
                    {
                        char symbol = matrix[row, col];

                        if (symbol != 'K')
                        {
                            continue;
                        }

                        int count = GetCountOfKnights(matrix, row, col);

                        if (count > maxAttackedKnights)
                        {
                            maxAttackedKnights = count;
                            knightRow = row;
                            knightCol = col;
                        }
                    }
                }

                if (maxAttackedKnights == 0)
                {
                    break;
                }

                matrix[knightRow, knightCol] = '0';
                removedKnightsCount++;
            }

            Console.WriteLine(removedKnightsCount);
        }

        private static int GetCountOfKnights(char[,] matrix, int row, int col)
        {
            int count = 0;

            if (ContainsKnights(matrix, row - 2, col - 1))
            {
                count++;
            }
            if (ContainsKnights(matrix, row - 2, col + 1))
            {
                count++;
            }
            if (ContainsKnights(matrix, row - 1, col - 2))
            {
                count++;
            }
            if (ContainsKnights(matrix, row - 1, col + 2))
            {
                count++;
            }
            if (ContainsKnights(matrix, row + 1, col - 2))
            {
                count++;
            }
            if (ContainsKnights(matrix, row + 1, col + 2))
            {
                count++;
            }
            if (ContainsKnights(matrix, row + 2, col - 1))
            {
                count++;
            }
            if (ContainsKnights(matrix, row + 2, col + 1))
            {
                count++;
            }

            return count;

        }
        private static bool ContainsKnights(char[,] matrix, int row, int col)
        {
            if (!IsValidCell(row, col, matrix.GetLength(0)))
            {
                return false;
            }

            return matrix[row, col] == 'K';
        }
        private static bool IsValidCell(int row, int col, int sizeOfBoard)
        {
            return row >= 0 && row < sizeOfBoard && col >= 0 && col < sizeOfBoard;
        }
    }
}
