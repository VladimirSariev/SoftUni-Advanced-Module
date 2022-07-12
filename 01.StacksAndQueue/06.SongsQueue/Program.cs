using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Queue<string> queue = new Queue<string>(songs);

            while (queue.Count > 0)
            {
                string input = Console.ReadLine();
                
                if (input.Contains("Play"))
                {
                    queue.Dequeue();
                }
                else if (input.Contains("Add"))
                {
                    string[] currentSong = input.Split("Add ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    
                    if (!queue.Contains(currentSong[0]))
                    {
                        queue.Enqueue(currentSong[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{currentSong[0]} is already contained!");
                    }
                }
                else
                {
                    Console.WriteLine($"{string.Join(", ", queue)}");
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
