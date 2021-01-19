using System;
using System.Linq;

namespace _06.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[row] = new int[input.Length];

                for (int col = 0; col < rows; col++)
                {
                    matrix[row][col] = input[col];
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                var splitted = command.Split();
                string cmnd = splitted[0];
                int roW = int.Parse(splitted[1]);
                int coL = int.Parse(splitted[2]);
                int value = int.Parse(splitted[3]);

                switch (cmnd)
                {
                    case "Add":

                        if (roW >= 0 && roW <= rows - 1  && coL >= 0 && coL <= rows - 1)
                        {
                            matrix[roW][coL] += value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                            command = Console.ReadLine();
                            continue;
                        }
                        break;

                    case "Subtract":

                        if (roW >= 0 && roW <= rows - 1 && coL >= 0 && coL <= rows - 1)
                        {
                            matrix[roW][coL] -= value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                            command = Console.ReadLine();
                            continue;
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
