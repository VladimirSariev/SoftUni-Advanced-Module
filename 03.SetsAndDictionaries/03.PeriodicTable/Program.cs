using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int rotations = int.Parse(Console.ReadLine());

            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < rotations; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int el = 0; el < input.Length; el++)
                {
                    elements.Add(input[el]);
                }
            }

            Console.WriteLine(string.Join(' ', elements));
        }
    }
}
