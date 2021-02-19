using System;

namespace _05.TronRaces
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int firstPlayerRow = 0;
            int firstPlayerCol = 0;
            int secondPlayerRow = 0;
            int secondPlayerCol = 0;

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'f')
                    {
                        firstPlayerRow = row;
                        firstPlayerCol = col;
                    }
                    else if (matrix[row, col] == 's')
                    {
                        secondPlayerRow = row;
                        secondPlayerCol = col;
                    }
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                string firstMovement = command[0];
                string secondMovement = command[1];

                matrix[firstPlayerRow, firstPlayerCol] = 'f';
                firstPlayerRow = MoveRow(firstPlayerRow, firstMovement);
                firstPlayerCol = MoveCol(firstPlayerCol, firstMovement);

                if (!IsPositionOut(firstPlayerRow, firstPlayerCol, n, n))
                {
                    switch (firstMovement)
                    {
                        case "up":
                            firstPlayerRow = n - 1;
                            break;

                            case "down":
                            firstPlayerRow = 0;
                            break;

                            case "left":
                            firstPlayerCol = n - 1;
                            break;

                            case "right":
                            firstPlayerCol = 0;
                            break;
                    }
                }

                matrix[secondPlayerRow, secondPlayerCol] = 's';
                secondPlayerRow = MoveRow(secondPlayerRow, secondMovement);
                secondPlayerCol = MoveCol(secondPlayerCol, secondMovement);

                if (!IsPositionOut(secondPlayerRow, secondPlayerCol, n, n))
                {
                    switch (secondMovement)
                    {
                        case "up":
                            secondPlayerRow = n - 1;
                            break;

                        case "down":
                            secondPlayerRow = 0;
                            break;

                        case "left":
                            secondPlayerCol = n - 1;
                            break;

                        case "right":
                            secondPlayerCol = 0;
                            break;
                    }
                }

                if (matrix[firstPlayerRow, firstPlayerCol] == 's')
                {
                    matrix[firstPlayerRow, firstPlayerCol] = 'x';
                    break;
                }

                if (matrix[secondPlayerRow, secondPlayerCol] == 'f')
                {
                    matrix[secondPlayerRow, secondPlayerCol] = 'x';
                    break;
                }
            }

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

        public static bool IsPositionOut(int row, int col, int rows, int cols)
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
