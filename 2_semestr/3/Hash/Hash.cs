namespace Hash
{
    using System;
    using List;

    /// <summary>
    /// Interface for hash function.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IHashFunction<T>
    {
         int HashFunction(T element, int sizeOfHashTable);
    }
 

    public class HashTable<T>
    {
        private const int sizeOfHashTable = 101;
        private List<T>[] buckets = new List<T>[sizeOfHashTable];

        /// <summary>
        /// Create hash table.
        /// </summary>
        /// <param name="hash"></param>
        public HashTable(IHashFunction<T> hash)
        {
            for (int i = 0; i != sizeOfHashTable; i++)
            {
                this.buckets[i] = new List<T>();
            }
            this.hash = hash;
        }

        /// <summary>
        /// Insert element to hash table.
        /// </summary>
        /// <param name="word"></param>
        public void InsertHashTable(T word)
        {
            this.buckets[this.hash.HashFunction(word, sizeOfHashTable)].Add(word);
        }

        /// <summary>
        /// Remove element from hash table.
        /// </summary>
        /// <param name="word"></param>
        public void RemoveHashElement(T word)
        {
            this.buckets[this.hash.HashFunction(word, sizeOfHashTable)].RemoveAt(this.buckets[this.hash.HashFunction(word, sizeOfHashTable)].FindIndex(word));
        }

        /// <summary>
        /// Check element in hash table is exist.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool ExistHashElement(T word)
        {
            return this.buckets[this.hash.HashFunction(word, sizeOfHashTable)].Contain(word);
        }

        /// <summary>
        /// Check hash table is empty. 
        /// </summary>
        /// <returns></returns>
        public bool Empty()
        {
            for (int i = 0; i != sizeOfHashTable; i++)
            {
                if (buckets[i].Size() != 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Print hash table.
        /// </summary>
        /// <returns></returns>
        public string PrintHashTable()
        {
            string hashTableString = "";
            for (int i = 0; i != sizeOfHashTable; i++)
            {
                if (buckets[i].Size() != 0)
                {
                    hashTableString += buckets[i].Write();
                }
            }
            return hashTableString;
        }

        private IHashFunction<T> hash;
    }

    class Program
    {
        static int Main()
        {
            return 0;
        }
    }
}
