using System;

namespace _05.Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int commands = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            bool hasWon = false;

            while (commands > 0)
            {
                string command = Console.ReadLine();
                int lastRow = playerRow;
                int lastCol = playerCol;

                matrix[playerRow, playerCol] = '-';
                playerRow = MoveRow(playerRow, command);
                playerCol = MoveCol(playerCol, command);

                if (!IsPositionValid(playerRow, playerCol, n, n))
                {
                    switch (command)
                    {
                        case "up":
                            playerRow = n - 1;
                            break;
                            case "down":
                            playerRow = 0;
                            break;
                            case "left":
                            playerCol = n - 1;
                            break;
                            case "right":
                            playerCol = 0;
                            break;
                    }
                }

                if (matrix[playerRow, playerCol] == 'B')
                {
                    //matrix[playerRow, playerCol] = '-';
                    playerRow = MoveRow(playerRow, command);
                    playerCol = MoveCol(playerCol, command);

                    if (!IsPositionValid(playerRow, playerCol, n, n))
                    {
                        switch (command)
                        {
                            case "up":
                                playerRow = n - 1;
                                break;
                            case "down":
                                playerRow = 0;
                                break;
                            case "left":
                                playerCol = n - 1;
                                break;
                            case "right":
                                playerCol = 0;
                                break;
                        }
                    }
                }

                if (matrix[playerRow, playerCol] == 'T')
                {
                    //matrix[playerRow, playerCol] = '-';
                    playerRow = lastRow;
                    playerCol = lastCol;
                }

                if (matrix[playerRow, playerCol] == 'F')
                {
                    Console.WriteLine("Player won!");
                    hasWon = true;
                    matrix[playerRow, playerCol] = 'f';
                    break;
                }

                matrix[playerRow, playerCol] = 'f';

                commands--;
            }

            if (!hasWon)
            {
                Console.WriteLine("Player lost!");
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
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
            if (movement == "left")
            {
                return col - 1;
            }
            if (movement == "right")
            {
                return col + 1;
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
