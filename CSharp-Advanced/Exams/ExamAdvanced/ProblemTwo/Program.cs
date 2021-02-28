using System;
using System.Linq;

namespace ProblemThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            int firstPlayerCount = 0;
            
            int secondPlayerCount = 0;

            string[] coordinates = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
            

            for (int row = 0; row < size; row++)
            {
                string[] currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = char.Parse(currentRow[col]);
                }
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == '<')
                    {
                        firstPlayerCount += 1;
                    }
                    else if (matrix[row, col] == '>')
                    {
                        secondPlayerCount += 1;
                    }
                }
            }

            int index = 0;
            int sunkedShips = 0;

            while (index < coordinates.Length)

            {
                string[] attackCoordinates = coordinates[index].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int attackRow = int.Parse(attackCoordinates[0]);
                int attackCol = int.Parse(attackCoordinates[1]);
                index++;

                if (!IsPositionValid(attackRow, attackCol, size, size))
                {
                    continue;
                }

                if (matrix[attackRow, attackCol] == '<')
                {
                    matrix[attackRow, attackCol] = 'X';
                    firstPlayerCount--;
                    sunkedShips++;
                }
                else if (matrix[attackRow, attackCol] == '>')
                {
                    matrix[attackRow, attackCol] = 'X';
                    secondPlayerCount--;
                    sunkedShips++;
                }
                else if (matrix[attackRow, attackCol] == '#')
                {
                    matrix[attackRow, attackCol] = 'X';

                    if (IsPositionValid(attackRow - 1, attackCol, size, size))
                    {
                        if (matrix[attackRow - 1, attackCol] == '<')
                        {
                            firstPlayerCount--;
                            sunkedShips++;
                        }
                        else if (matrix[attackRow - 1, attackCol] == '>')
                        {
                            secondPlayerCount--;
                            sunkedShips++;
                        }
                        matrix[attackRow - 1, attackCol] = 'X';
                    }

                    if (IsPositionValid(attackRow - 1, attackCol + 1, size, size))
                    {
                        if (matrix[attackRow - 1, attackCol + 1] == '<')
                        {
                            firstPlayerCount--;
                            sunkedShips++;
                        }
                        else if (matrix[attackRow - 1, attackCol + 1] == '>')
                        {
                            secondPlayerCount--;
                            sunkedShips++;
                        }
                        matrix[attackRow - 1, attackCol + 1] = 'X';
                    }

                    if (IsPositionValid(attackRow, attackCol + 1, size, size))
                    {
                        if (matrix[attackRow, attackCol + 1] == '<')
                        {
                            firstPlayerCount--;
                            sunkedShips++;
                        }
                        else if (matrix[attackRow, attackCol + 1] == '>')
                        {
                            secondPlayerCount--;
                            sunkedShips++;
                        }
                        matrix[attackRow, attackCol + 1] = 'X';
                    }

                    if (IsPositionValid(attackRow + 1, attackCol + 1, size, size))
                    {
                        if (matrix[attackRow + 1, attackCol + 1] == '<')
                        {
                            firstPlayerCount--;
                            sunkedShips++;
                        }
                        else if (matrix[attackRow + 1, attackCol + 1] == '>')
                        {
                            secondPlayerCount--;
                            sunkedShips++;
                        }
                        matrix[attackRow + 1, attackCol + 1] = 'X';
                    }

                    if (IsPositionValid(attackRow + 1, attackCol, size, size))
                    {
                        if (matrix[attackRow + 1, attackCol] == '<')
                        {
                            firstPlayerCount--;
                            sunkedShips++;
                        }
                        else if (matrix[attackRow + 1, attackCol] == '>')
                        {
                            secondPlayerCount--;
                            sunkedShips++;
                        }
                        matrix[attackRow + 1, attackCol] = 'X';
                    }

                    if (IsPositionValid(attackRow + 1, attackCol - 1, size, size))
                    {
                        if (matrix[attackRow + 1, attackCol - 1] == '<')
                        {
                            firstPlayerCount--;
                            sunkedShips++;
                        }
                        else if (matrix[attackRow + 1, attackCol - 1] == '>')
                        {
                            secondPlayerCount--;
                            sunkedShips++;
                        }
                        matrix[attackRow + 1, attackCol - 1] = 'X';
                    }

                    if (IsPositionValid(attackRow, attackCol - 1, size, size))
                    {
                        if (matrix[attackRow, attackCol - 1] == '<')
                        {
                            firstPlayerCount--;
                            sunkedShips++;
                        }
                        else if (matrix[attackRow, attackCol - 1] == '>')
                        {
                            secondPlayerCount--;
                            sunkedShips++;
                        }
                        matrix[attackRow, attackCol - 1] = 'X';
                    }

                    if (IsPositionValid(attackRow - 1, attackCol - 1, size, size))
                    {
                        if (matrix[attackRow - 1, attackCol - 1] == '<')
                        {
                            firstPlayerCount--;
                            sunkedShips++;
                        }
                        else if (matrix[attackRow - 1, attackCol - 1] == '>')
                        {
                            secondPlayerCount--;
                            sunkedShips++;
                        }
                        matrix[attackRow - 1, attackCol - 1] = 'X';
                    }
                }
            }

            if (firstPlayerCount > 0 && secondPlayerCount > 0)
            {
                Console.WriteLine($"It's a draw! Player One has {firstPlayerCount} ships left. Player Two has {secondPlayerCount} ships left.");
            }
            else if (firstPlayerCount > 0)
            {
                Console.WriteLine($"Player One has won the game! {sunkedShips} ships have been sunk in the battle.");
            }
            else
            {
                Console.WriteLine($"Player Two has won the game! {sunkedShips} ships have been sunk in the battle.");
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
