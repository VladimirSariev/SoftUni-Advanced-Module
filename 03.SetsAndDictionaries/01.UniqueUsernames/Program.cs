using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                names.Add(input);
                input = Console.ReadLine();
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }


        }
    }
}
