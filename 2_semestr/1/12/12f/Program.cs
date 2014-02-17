using System;

namespace Factorial
{
    class Program
    {
        // Calculate factorial iterative method.
        public static long FactorialIterative(long value)
        {
            if (value == 0 || value == 1)
            {
                return 1;
            }
            else
            {
                long factorial = 1;
                for (long i = 1; i <= value; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
        }

        // Calculate factorial recursive method.
        public static long FactorialRecursive(long value)
        {
            if (value == 1 || value == 0)
            {
                return 1;
            }
            else
            {
                return FactorialRecursive(value - 1) * value;
            }
        }

        // Calculating factorial.
        // Test is positive with "10".
        // Test is negative with "1.2'.
        public static void Main()
        {
            System.Console.Write("Enter your value: ");
            long value = long.Parse(System.Console.ReadLine());
            if (value < 0)
            {
                System.Console.WriteLine("Error");
            }
            System.Console.WriteLine("Factorial = {0}", FactorialIterative(value));
        }
    }
}
