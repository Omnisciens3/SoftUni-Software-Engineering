using System;

namespace _02.Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int myPositionRow = 0;
            int myPositionCol = 0;

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'S')
                    {
                        myPositionRow = row;
                        myPositionCol = col;
                    }
                }
            }

            double count = 0;

            while (count < 50)
            {
                string movement = Console.ReadLine();
                matrix[myPositionRow, myPositionCol] = '-';
                myPositionRow = MoveRow(myPositionRow, movement);
                myPositionCol = MoveCol(myPositionCol, movement);

                if (!IsPositionValid(myPositionRow, myPositionCol, n, n))
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");
                    break;
                }

                char isDigit = matrix[myPositionRow, myPositionCol];
                

                if (Char.IsDigit(isDigit))
                {
                    double sum = Char.GetNumericValue(matrix[myPositionRow, myPositionCol]);
                    count += sum;
                    matrix[myPositionRow, myPositionCol] = '-';
                }

                if (matrix[myPositionRow, myPositionCol] == 'O')
                {
                    matrix[myPositionRow, myPositionCol] = '-';

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            if (matrix[row, col] == 'O')
                            {
                                matrix[myPositionRow, myPositionCol] = '-';
                                myPositionRow = row;
                                myPositionCol = col;
                            }
                        }
                    }
                }

                matrix[myPositionRow, myPositionCol] = 'S';
            }

            if (count >= 50)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }

            Console.WriteLine($"Money: {count}");

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
