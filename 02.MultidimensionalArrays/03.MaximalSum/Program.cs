using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int r = int.Parse(input.Split()[0]);
            int c = int.Parse(input.Split()[1]);

            int[,] matrix = new int[r, c];
            FillTheMatrix(matrix);

            
            long maxSum = long.MinValue;

            int rowIndex = 0;
            int colIndex = 0;
            

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                long sum = 0;
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[rowIndex, colIndex]} {matrix[rowIndex, colIndex + 1]} {matrix[rowIndex, colIndex + 2]}");
            Console.WriteLine($"{matrix[rowIndex + 1, colIndex]} {matrix[rowIndex + 1, colIndex + 1]} {matrix[rowIndex + 1, colIndex + 2]}");
            Console.WriteLine($"{matrix[rowIndex + 2, colIndex]} {matrix[rowIndex + 2, colIndex + 1]} {matrix[rowIndex + 2, colIndex + 2]}");


                





        }

        private static void FillTheMatrix(int[,] matrix)
            {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

        }

    }
}
