using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            //Action<T>;
            Action<List<string>> printNames = names => Console.WriteLine(string.Join(Environment.NewLine, names));

            printNames(names);
        }
    }
}
