using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(numbers);

            int rackCounter = 0;
            int sum = 0;

            while (stack.Count > 0)
            {
                int currentPiece = stack.Peek();
               
                if (sum + currentPiece > rackCapacity)
                {
                    rackCounter++;
                    sum = 0;
                }
                else if (sum + currentPiece == rackCapacity)
                {
                    rackCounter++;
                    stack.Pop();
                    sum = 0;
                }
                else
                {
                    sum += currentPiece;
                    stack.Pop();
                }
            }

            if (sum > 0)
            {
                rackCounter++;
            }

            Console.WriteLine(rackCounter);
        }
    }
}
