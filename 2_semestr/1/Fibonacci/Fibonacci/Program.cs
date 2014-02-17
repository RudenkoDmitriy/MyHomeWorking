using System;

namespace Fibonacci
{
    class Program
    {
        // Calculate fibonachi recursive method.
        public static long FibonacciRecursive(long value)
        {
            if (value == 0)
            {
                return 0;
            }
            if (value == 1)
            {
                return 1;
            }
            return FibonacciRecursive(value - 1) + FibonacciRecursive(value - 2);
        }

        // Calculate fibonachi iterative method.
        public static long FibonacciIterative(long value)
        {
            if (value == 0)
            {
                return 0;
            }
            if (value == 1)
            {
                return 1;
            }
            long firstNumber = 0;
            long secondNumber = 1;
            while (value > 1)
            {
                long temp = secondNumber;
                secondNumber += firstNumber;
                firstNumber = temp;
                value--;
            }
            return secondNumber;
        }

        // Calculating fibonachi.
        // Test is positive with "10".
        // Test is begative with "1.2".
        public static void Main()
        {
            System.Console.Write("Enter the number of the number:");
            long number = long.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Your number is {0}", FibonacciIterative(number));
        }
    }
}
