using System;
using System.Text;

namespace _02.BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < n; row++)
            {
                string matrixInput = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = matrixInput[col];

                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            string movement = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(input);
            
            while (movement != "end")
            {
                matrix[playerRow, playerCol] = '-';
                int lastRow = playerRow;
                int lastCol = playerCol;
                playerRow = MoveRow(playerRow, movement);
                playerCol = MoveCol(playerCol, movement);

                if (!IsPositionValid(playerRow, playerCol, n, n))
                {
                    playerRow = lastRow;
                    playerCol = lastCol;
                    int startIndex = sb.Length - 1;
                    sb.Remove(startIndex, 1);
                }

                if (Char.IsLetter(matrix[playerRow, playerCol]))
                {
                    sb.Append(matrix[playerRow, playerCol]);
                }

                matrix[playerRow, playerCol] = 'P';
                movement = Console.ReadLine();
            }

            Console.WriteLine(sb);

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static int MoveRow(int row, string movement)
        {
            if (movement == "up")
            {
                return row - 1;
            }
            if (movement == "down")
            {
                return row + 1;
            }
            return row;
        }

        public static int MoveCol(int col, string movement)
        {
            if (movement == "right")
            {
                return col + 1;
            }
            if (movement == "left")
            {
                return col - 1;
            }
            return col;
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
