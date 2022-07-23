using System;

namespace _05.SnakeMoves
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

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        static void FillTheMatrix(string[,] matrix)
        {
            int counter = 0;
            string input = Console.ReadLine();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (counter == input.Length)
                        {
                            counter = 0;
                            matrix[row, col] = input[counter].ToString();
                            counter++;

                        }
                        else
                        {
                            matrix[row, col] = input[counter].ToString();
                            counter++;
                        }
                    }
                }

                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        if (counter == input.Length)
                        {
                            counter = 0;
                            matrix[row, col] = input[counter].ToString();
                            counter++;


                        }
                        else
                        {
                            matrix[row, col] = input[counter].ToString();
                            counter++;
                        }

                    }
                }
                
            }
        }
    }
}
