using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            for (int row = 0; row < matrix.Length - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    matrix[row] = matrix[row].Select(x => x * 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    matrix[row] = matrix[row].Select(x => x / 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(x => x / 2).ToArray();
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] splittedInput = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = splittedInput[0];
                if (command == "Add")
                {
                    int row = int.Parse(splittedInput[1]);
                    int column = int.Parse(splittedInput[2]);
                    int value = int.Parse(splittedInput[3]);

                    if (row >= 0 && row < rows && column >= 0 && column < matrix[row].Length)
                    {
                        matrix[row][column] += value;
                    }
                }
                else if (command == "Subtract")
                {
                    int row = int.Parse(splittedInput[1]);
                    int column = int.Parse(splittedInput[2]);
                    int value = int.Parse(splittedInput[3]);

                    if (row >= 0 && row < rows && column >= 0 && column < matrix[row].Length)
                    {
                        matrix[row][column] -= value;
                    }
                }
            }


            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join(' ', item));
            }
        }
    }
}
