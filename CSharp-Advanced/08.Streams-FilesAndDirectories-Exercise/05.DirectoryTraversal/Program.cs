using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> fileInfo = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo directoryInfo = new DirectoryInfo("../../../");
            FileInfo[] files = directoryInfo.GetFiles();

            foreach (var file in files)
            {
                if (!fileInfo.ContainsKey(file.Extension))
                {
                    fileInfo.Add(file.Extension, new Dictionary<string, double>());
                }

                fileInfo[file.Extension].Add(file.Name, file.Length / 1024.00);
            }

            using (StreamWriter writer = new StreamWriter
                (@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\report.txt"))
            {
                foreach (var extension in fileInfo.OrderByDescending(f => f.Value.Count).ThenBy(e => e.Key))
                {
                    writer.WriteLine(extension.Key);

                    foreach (var item in extension.Value.OrderBy(i => i.Value))
                    {
                        writer.WriteLine($"--{item.Key} - {item.Value}kb");
                    }
                }
            }
        }
    }
}
