using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    /// <summary>
    /// Other hash function for integer.
    /// </summary>
    public class OtherHashFunctionInt : IHashFunction<int>
    {
        public int HashFunction(int element, int sizeOfHashTable)
        {
            return (element % sizeOfHashTable);
        }
    }
}
