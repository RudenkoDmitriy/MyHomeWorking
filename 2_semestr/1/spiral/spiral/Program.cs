using System;

namespace Spiral
{
    class Program
    {
        // Write matrix in in the form of a spiral. 
        static void Spiral(int[,] matrix, int size)
        {
            int i = size / 2; // Center
            int j = size / 2; // Center
            int numberOfSteps = 1;
            int directions = 0;
            int commitedSteps = 0;
            Console.Write("{0} ", matrix[i, j]);
            for (int count = 0; count < size * size - 1; count++)
            {
                switch (directions % 4)
                {
                    case 0:
                        {
                            i--;
                            Console.Write("{0} ", matrix[i, j]);
                            break;
                        }
                    case 1:
                        {
                            j++;
                            Console.Write("{0} ", matrix[i, j]);
                            break;
                        }
                    case 2:
                        {
                            i++;
                            Console.Write("{0} ", matrix[i, j]);
                            break;
                        }
                    case 3:
                        {
                            j--;
                            Console.Write("{0} ", matrix[i, j]);
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                commitedSteps++;
                if (commitedSteps == numberOfSteps)
                {
                    directions++;
                    commitedSteps = 0;
                    if (directions % 2 == 0)
                    {
                        numberOfSteps++;
                    }
                }
            }
            Console.WriteLine();
        }

        // Create random matrix.
        static int[,] CreateRandomMatrix(int size)
        {
            Random rand = new Random();
            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rand.Next(0, 30);
                }
            }
            return matrix;
        }

        // Write matrix.
        static void WriteMatrix(int[,] matrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        // Write matrix in the form of a spiral.
        // Test is positive with "3".
        // Test is negative with "1.2".
        static void Main(string[] args)
        {
            Console.Write("Enter the size of matrix: ");
            int size = Int32.Parse(Console.ReadLine());
            if (size % 2 == 0 || size <= 0)
            {
                Console.WriteLine("Error");
                return;
            }
            int[,] matrix = CreateRandomMatrix(size);
            WriteMatrix(matrix, size);
            Console.WriteLine();
            Spiral(matrix, size);
        }
    }
}
