using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            long primarySum = 0;
            long secondarySum = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == col)
                    {
                        primarySum += matrix[row, col];
                    }
                    if ((row + col) == (n - 1))
                    {
                        secondarySum += matrix[row, col];
                    }
                }
                
            }
            long theAbsolute = Math.Abs(primarySum - secondarySum);
            Console.WriteLine(theAbsolute);
        }
    }
}
