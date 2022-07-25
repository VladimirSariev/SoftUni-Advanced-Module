using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int rotations = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();
            string[] separators = new string[] { " -> ", "," };

            for (int i = 0; i < rotations; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string color = input[0];
                

                if (!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }
                for (int currentItem = 1; currentItem < input.Length; currentItem++)
                {
                    if (!clothes[color].ContainsKey(input[currentItem]))
                    {
                        clothes[color].Add(input[currentItem], 1);
                    }
                    else
                    {
                        clothes[color][input[currentItem]]++;
                    }
                }


            }

            string[] toFind = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string colorToFind = toFind[0];
            string pieceOfClothing = toFind[1];

            foreach (var color in clothes)
            {
                Console.WriteLine(color.Key + " " + "clothes:");
                foreach (var cloth in color.Value)
                {
                    if (color.Key == colorToFind && cloth.Key == pieceOfClothing)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
                
            }
            
        }
    }
}
