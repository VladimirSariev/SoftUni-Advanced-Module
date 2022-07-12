using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPetrolPumps = int.Parse(Console.ReadLine());
            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < numberOfPetrolPumps; i++)
            {
                int[] currentStation = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                queue.Enqueue(currentStation);
            }

            int startIndex = 0;
            
            while (queue.Count > 0)
            {
                
                int totalLiters = 0;
                bool isComplete = true;
                foreach (int[] item in queue)
                {
                    int liters = item[0];
                    int distance = item[1];
                    totalLiters += liters;
                    if (totalLiters - distance < 0)
                    {
                        startIndex++;
                        int[] currentPump = queue.Dequeue();
                        queue.Enqueue(currentPump);
                        isComplete = false;
                        break;
                    }
                    totalLiters -= distance;
                }

                if (isComplete)
                {
                    Console.WriteLine(startIndex);
                    break;
                }
            }
        }
    }
}
