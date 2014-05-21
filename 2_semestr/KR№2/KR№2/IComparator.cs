using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_2
{
    /// <summary>
    /// Interface for comparator.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IComparator<T>
    {
        bool CompareTo(T firstElement, T secondElement);
    }
}
