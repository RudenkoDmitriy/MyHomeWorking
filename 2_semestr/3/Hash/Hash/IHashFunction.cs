using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    /// <summary>
    /// Interface for hash function.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IHashFunction<T>
    {
        int HashFunction(T element, int sizeOfHashTable);
    }
 
}
