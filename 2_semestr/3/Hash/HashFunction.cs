
namespace Hash
{
    using System;

    /// <summary>
    /// Hash function for string.
    /// </summary>
    public class HashFunctionString : IHashFunction<string>
    {
        public int HashFunction(string element, int sizeOfHashTable)
        {
            ulong result = 0;
            string temp = element.ToString();
            for (int i = 0; i != temp.Length; i++)
            {
                result += (ulong)(temp[i] * Math.Pow(101, i));
            }
            return (int)(result %= (ulong)sizeOfHashTable);
        }
    }

    /// <summary>
    /// Hash function for integer.
    /// </summary>
    public class HashFunctionInt : IHashFunction<int>
    {
        public int HashFunction(int element, int sizeOfHashTable)
        {
            return (element.GetHashCode() % sizeOfHashTable);
        }
    }
}
