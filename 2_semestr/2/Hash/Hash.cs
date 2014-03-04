namespace Hash
{
    using System;
    using Program;
    class HashTable<T>
    {
        private const int sizeOfHashTable = 101;
        private List<T>[] buckets = new List<T>[sizeOfHashTable];

        public HashTable()
        {
            for (int i = 0; i != sizeOfHashTable; i++)
            {
                this.buckets[i] = new List<T>();
            }
        }

        /// <summary>
        /// Calculating hash function. 
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        private int HashFunction(T element)
        {
            ulong result = 0;
            string temp = element.ToString();
            for (int i = 0; i != temp.Length; i++)
            {
                result += (ulong)(temp[i] * Math.Pow(101, i));
            }
            return (int)(result %= sizeOfHashTable);
        }

        /// <summary>
        /// Insert to hash table input element.
        /// </summary>
        /// <param name="word"></param>
        public void InsertHashTable(T word)
        {
            this.buckets[HashFunction(word)].Add(word);
        }

        /// <summary>
        /// Remove element from table.
        /// </summary>
        /// <param name="word"></param>
        public void RemoveHashElement(T word)
        {
            this.buckets[HashFunction(word)].RemoveAt(this.buckets[HashFunction(word)].FindIndex(word));
        }

        /// <summary>
        /// Check element is exist in table.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool ExistHashElement(T word)
        {
            return this.buckets[HashFunction(word)].Contain(word);
        }

        /// <summary>
        /// Print all hash table.
        /// </summary>
        public void PrintHashTable()
        {
            for (int i = 0; i != sizeOfHashTable; i++)
            {
                this.buckets[i].Write();
            }
        }
    }
}
