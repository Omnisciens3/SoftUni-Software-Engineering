using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<string, string> func = (name) =>
            //{
            //    return $"Sir {name}";
            //};

            //Func<string, string> func = name => $"Sir {name}"; -- Съкратен вариант на горния.

            List<string> names = Console.ReadLine().Split().ToList();

            List<string> newNames = names.Select(name => $"Sir {name}").ToList();

            //Action<T>;
            Action<List<string>> printNames = names => Console.WriteLine(string.Join(Environment.NewLine, newNames));

            printNames(newNames);
        }
        //static string FuncMethod(string name)
        //{
        //    return $"Sir {name}";
        //}
    }
}
