using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
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

           Queue<int> queue = new Queue<int>();

            int toPush = numbers[0];
            int toPop = numbers[1];
            int magicNumber = numbers[2];

            for (int i = 0; i < toPush; i++)
            {
                queue.Enqueue(actionNumbers[i]);
            }

            if (queue.Count > 0)
            {
                for (int i = 0; i < toPop; i++)
                {
                    queue.Dequeue();
                    if (queue.Count == 0)
                    {
                        Console.WriteLine(0);
                        return;
                    }
                }
            }

            if (queue.Count> 0 && queue.Contains(magicNumber))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
