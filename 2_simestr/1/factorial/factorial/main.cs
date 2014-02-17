using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class main
    {
        // Calculate factorial iterative method.
        public static long FactorialEmpty(long value)
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
        public static long FactorialRecurs(long value)
        {
            if (value == 1 || value == 0)
            {
                return 1;
            }
            else
            {
                return FactorialRecurs(value - 1) * value;
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
            System.Console.WriteLine("Factorial = {0}", FactorialEmpty(value));
        }
    }
}
