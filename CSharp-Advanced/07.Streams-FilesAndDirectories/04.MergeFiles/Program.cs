using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04.MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = "../../../";
            string firstFileName = "fileOne.txt";
            string secondFileName = "fileTwo.txt";

            string firstFilePath = Path.Combine(folderPath, firstFileName);
            string secondFilePath = Path.Combine(folderPath, secondFileName);

            var mergedList = new List<string>();

            var firstFileLines = File.ReadAllLines(firstFilePath);
            var secondFileLines = File.ReadAllLines(secondFilePath);

            foreach (var line in firstFileLines)
            {
                mergedList.Add(line);
            }

            foreach (var line in secondFileLines)
            {
                mergedList.Add(line);
            }

            string outputFilePath = "output.txt";

            File.WriteAllLines(outputFilePath, mergedList.OrderBy(x => x));
        }
    }
}
