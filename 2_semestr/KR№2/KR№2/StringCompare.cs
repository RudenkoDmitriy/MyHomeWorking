using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_2
{
    /// <summary>
    /// Class-comparator for string. Sorting in lexicographically
    /// </summary>
    public class StringCompare : IComparator<string>
    {
        /// <summary>
        /// Compare two strings.
        /// </summary>
        /// <param name="firstElement"></param>
        /// <param name="secondElement"></param>
        /// <returns></returns>
        public bool CompareTo(string firstElement, string secondElement)
        {
            if (String.Compare(firstElement, secondElement) <= 0)
            {
                return true;
            }
            return false;
        }
    }
}
