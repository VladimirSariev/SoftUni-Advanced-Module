using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int rotations = int.Parse(Console.ReadLine());

            StringBuilder text = new StringBuilder();
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < rotations; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = input[0];
                if (command == "1")
                {
                    string textToAdd = input[1];
                    stack.Push(text.ToString());
                    text.Append(textToAdd);
                }
                else if (command == "2")
                {
                    stack.Push(text.ToString());
                    int charsToRemove = int.Parse(input[1]);
                    text.Remove(text.Length - charsToRemove, charsToRemove);
                }
                else if (command == "3")
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else
                {
                    text = new StringBuilder(stack.Pop());
                }
            }
        }
    }
}
