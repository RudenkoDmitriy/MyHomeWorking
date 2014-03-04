namespace Program
{
    using System;
    using Hash;
    class Program
    {
        static void Main(string[] args)
        {
            HashTable<string> table = new HashTable<string>();
            table.InsertHashTable("Strochka");
            if (table.ExistHashElement("Strochka"))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            table.RemoveHashElement("Strochka");
            if (table.ExistHashElement("Strochka"))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
