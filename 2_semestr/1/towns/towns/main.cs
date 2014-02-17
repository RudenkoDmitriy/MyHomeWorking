using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towns
{
    class main
    {
        // Swap for towns.
        static void SwapForTown(int[,] matrix, int firstTown, int secondTown, int stringsNumber)
        {
            for (int i = 0; i < stringsNumber; i++)
            {
                int temp = matrix[i , firstTown];
                matrix[i, firstTown] = matrix[i, secondTown];
                matrix[i, secondTown] = temp;
            }
        }
        // Inserting sort by towns by first elements for matrix.
        static void InsertingSort(int[,] matrix, int stringsNumber, int townsNumber)
        {
            for (int i = 0; i < townsNumber; i++)
            {
                for (int j = i; j > 0 && matrix[0, j - 1] > matrix[0, j]; j--)
                {
                    SwapForTown(matrix, j - 1, j, stringsNumber);
                }
            }
        }
        // Create random matrix.
        static void RandomMatrix(int[,] matrix, int stringsNumber, int townsNumber)
        {
            Random rand = new Random();
            for (int i = 0; i < stringsNumber; i++)
            {
                for (int j = 0; j < townsNumber; j++)
                {
                    matrix[i, j] = rand.Next(0, 30);
                }
            }
        }
        // Write matrix.
        static void WriteMatrix(int[,] matrix, int stringsNumber, int townsNumber)
        {
            for (int i = 0; i < stringsNumber; i++)
            {
                for (int j = 0; j < townsNumber; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        // Sorting matrix's towns by first elements.
        // Test is positive with "3, 20".
        // Test is negative with "1.2".
        static void Main(string[] args)
        {
            Console.Write("Enter the number of strings of matrix: ");
            int stringsNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the number of towns of matrix: ");
            int townsNumber = Int32.Parse(Console.ReadLine());
            if (stringsNumber <= 0 || townsNumber <= 0)
            {
                Console.WriteLine("Error");
                return;
            }
            int[,] matrix = new int[stringsNumber, townsNumber];
            RandomMatrix(matrix, stringsNumber, townsNumber);
            Console.WriteLine("Is your matrix: ");
            WriteMatrix(matrix, stringsNumber, townsNumber);
            Console.WriteLine();
            Console.WriteLine("Sorted matrix: ");
            InsertingSort(matrix, stringsNumber, townsNumber);
            WriteMatrix(matrix, stringsNumber, townsNumber);
        }
    }
}
