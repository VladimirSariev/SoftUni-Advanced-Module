using System;
using System.Collections.Generic;

namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool isBalanced = true;
            for (int i = 0; i < input.Length; i++)
            {
                char currCh = input[i];

                if (currCh == '{' || currCh == '[' || currCh == '(')
                {
                    stack.Push(currCh);
                    continue;
                }

                if (stack.Count == 0)
                {
                    isBalanced = false;
                    break;
                }

                if (currCh == '}' && stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else if (currCh == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else if(currCh == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else
                {
                    isBalanced = false;
                    break;
                }
            }

            if (!isBalanced)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
