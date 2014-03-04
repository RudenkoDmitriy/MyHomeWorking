namespace Program
{
    using System;
    using List;
    class Program
    {
        // Example program.
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            Console.WriteLine(list.Write());

        }
    }
}
