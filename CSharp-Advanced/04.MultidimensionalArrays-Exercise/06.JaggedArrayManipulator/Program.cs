using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[][] jaggedArray = new double[n][];

            //for (int row = 0; row < n; row++)
            //{
            //    double[] rowData = Console.ReadLine().Split().Select(double.Parse).ToArray();
            //    jaggedArray[row] = new double[rowData.Length];

            //    for (int col = 0; col < jaggedArray.Length; col++)
            //    {
            //        jaggedArray[row][col] = rowData[col];
            //    }
            //}

            for (int row = 0; row < n; row++)    // това е съкратен запис на горният - за назъбени матрици.
            {
                jaggedArray[row] = Console.ReadLine().Split().Select(double.Parse).ToArray(); 
            }

            for (int row = 0; row < n - 1; row++)
            {
                double[] firstRow = jaggedArray[row];
                double[] secondRow = jaggedArray[row + 1];

                if (firstRow.Length == secondRow.Length)
                {
                    jaggedArray[row] = firstRow.Select(e => e * 2).ToArray();
                    jaggedArray[row + 1] = secondRow.Select(e => e * 2).ToArray();
                }
                else
                {
                    jaggedArray[row] = firstRow.Select(e => e / 2).ToArray();
                    jaggedArray[row + 1] = secondRow.Select(e => e / 2).ToArray();
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArgs = command.Split();
                int rowIndex = int.Parse(cmdArgs[1]);
                int colIndex = int.Parse(cmdArgs[2]);
                int value = int.Parse(cmdArgs[3]);

                if (rowIndex >= 0 && rowIndex < n && colIndex >= 0 && colIndex < jaggedArray[rowIndex].Length)
                {
                    if (cmdArgs[0] == "Add")
                    {
                        jaggedArray[rowIndex][colIndex] += value;
                    }
                    else
                    {
                        jaggedArray[rowIndex][colIndex] -= value;
                    }
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[i]));
            }
        }
    }
}
