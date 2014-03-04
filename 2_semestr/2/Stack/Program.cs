namespace Program
{
    using System;
    using StackCalculator;
    class Program
    {
        // Example program.
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(3);
            stack.Push(2);
            stack.Clear();
            stack.Push(2);
            stack.Write();
        }
    }
}
