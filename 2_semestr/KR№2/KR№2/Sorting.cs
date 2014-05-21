using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_2
{
    /// <summary>
    /// Class of sorting methods.
    /// </summary>
    public class Sorting
    {
        /// <summary>
        /// Bubble sorting.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="sizeOfArray"></param>
        /// <param name="comparator"></param>
        public static void BubbleSort<T>(T[] array, int sizeOfArray, IComparator<T> comparator)
        {
            for (int i = 0; i != sizeOfArray; i++)
            {
                for (int j = 0; j != sizeOfArray - 1; j++)
                {
                    if (comparator.CompareTo(array[j], array[j + 1]))
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

    }
}
