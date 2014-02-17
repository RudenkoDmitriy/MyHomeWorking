using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    class main
    {
        // Sorting input array by Inserting Sort.
        static void InsertingSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j > 0 && array[j - 1] > array[j]; j--)
                {
                    int temp = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = temp;
                }
            }
        }
        // Fills input array random numbers.
        static void createRandomArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 30);
            }
        }
        // Writing input array.
        static void writeArray(int[] array)
        {
            Console.Write("Your array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
        // Sorting array.
        // Test is positive with "10".
        // Test is negative with "-1" or "1.2".
        static void Main(string[] args)
        {
            Console.Write("Enter the length of array ");
            int lengthOfArray = Int16.Parse(Console.ReadLine());
            int[] array = new int[lengthOfArray];
            createRandomArray(array);
            writeArray(array);
            Console.Write("After sorting...");
            InsertingSort(array);
            Console.WriteLine();
            writeArray(array);
        }
    }
}
