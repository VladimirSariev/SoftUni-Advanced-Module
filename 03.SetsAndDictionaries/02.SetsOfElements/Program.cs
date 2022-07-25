using System;
using System.Collections.Generic;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int first = int.Parse(input.Split(' ')[0]);
            int second = int.Parse(input.Split(' ')[1]);

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < first; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < second; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }
            foreach (var number in firstSet)
            {
                foreach (var num in secondSet)
                {
                    if (number.Equals(num))
                    {
                        Console.Write(number + " ");
                    }
                }
            }
        }
    }
}
