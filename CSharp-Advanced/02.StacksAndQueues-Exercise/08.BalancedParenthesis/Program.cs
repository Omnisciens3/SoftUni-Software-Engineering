using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> open = new Stack<char>();

            string input = Console.ReadLine();

            bool isBalanced = true;

            foreach (char ch in input)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    open.Push(ch);
                }
                else
                {
                    bool isFirstValid = ch == ')' && open.Pop() == '(';
                    bool isSecondValid = ch == '}' && open.Pop() == '{';
                    bool isThirdValid = ch == ']' && open.Pop() == '[';

                    if (!isFirstValid && !isSecondValid && !isThirdValid)
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
