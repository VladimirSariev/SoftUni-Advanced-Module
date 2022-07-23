using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int r = int.Parse(input.Split()[0]);
            int c = int.Parse(input.Split()[1]);

            string[,] matrix = new string[r, c];
            FillTheMatrix(matrix);

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmndArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string splittedCommand = cmndArg[0];

                if (splittedCommand == "swap" && cmndArg.Length == 5)
                {
                    int row1 = int.Parse(cmndArg[1]);
                    int col1 = int.Parse(cmndArg[2]);
                    int row2 = int.Parse(cmndArg[3]);
                    int col2 = int.Parse(cmndArg[4]);

                    if (row1 >= 0 && row1 < r && col1 >= 0 && col1 < c 
                        && row2 >= 0 && row2 < r && col2 >= 0 && col2 < c)
                    {
                        string temp = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temp;

                        for (int row = 0; row < r; row++)
                        {
                            for (int col = 0; col < c; col++)
                            {
                                Console.Write($"{matrix[row,col]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
            }
            

           


        }
        private static void FillTheMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                    

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

        }
    }
}
