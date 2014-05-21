using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_2
{
    /// <summary>
    /// Class-comparator for int. Sorting in descending order. 
    /// </summary>
    public class IntComapare : IComparator<int>
    {
        public bool CompareTo(int firstElement, int secondElement)
        {
            return firstElement <= secondElement;
        }
    }
}
