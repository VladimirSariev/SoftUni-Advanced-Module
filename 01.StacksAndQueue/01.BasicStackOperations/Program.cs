using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] actionNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();
            bool isFound = false;

            int toPush = numbers[0];
            int toPop = numbers[1];
            int magicNumber = numbers[2];

            int minimum = int.MaxValue;

            for (int i = 0; i < toPush; i++)
            {
                stack.Push(actionNumbers[i]);
            }

            if (stack.Count > 0)
            {
                for (int i = 0; i < toPop; i++)
                {
                    stack.Pop();
                    if (stack.Count == 0)
                    {
                        Console.WriteLine(0);
                        return;
                    }

                }
            }
            else
            {
                Console.WriteLine(0);
                return;
            }

            if (stack.Count > 0)
            {
                foreach (int item in stack)
                {
                    if (item == magicNumber)
                    {
                        Console.WriteLine("true");
                        isFound = true;
                        return;
                    }
                    else if (item <= minimum)
                    {
                        minimum = item;
                    }
                }
            }

            if (isFound == false)
            {
                Console.WriteLine(minimum);
            }

        }
    }
}
