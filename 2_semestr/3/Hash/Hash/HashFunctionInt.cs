using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
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
