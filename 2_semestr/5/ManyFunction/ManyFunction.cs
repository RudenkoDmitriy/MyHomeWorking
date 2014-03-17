using System;
using System.Collections.Generic;

namespace ManyFunction
{
    /// <summary>
    /// Class with many interesting functions. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ManyFunctionClass<T>
    {
        /// <summary>
        /// Return list with changed elements by input function.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public static List<T> Map(List<T> list, Func<T, T> function)
        {
            List<T> result = new List<T>();
            foreach(var x in list)
            {
                result.Insert(result.Count, function(x));
            }
            return result;
        }

        /// <summary>
        /// Return list with element satisfying input bool element.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public static List<T> Filter(List<T> list, Func<T, bool> function)
        {
            List<T> result = new List<T>();
            foreach (var x in list)
            {
                if (function(x))
                {
                    result.Insert(result.Count, x);
                }
            }
            return result;
        }

        /// <summary>
        /// Return result by applying a function to all elements of the list.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="firstValue"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public static int Fold(List<T> list, int firstValue, Func<int, T, int> function)
        {
            foreach (var x in list)
            {
                firstValue = function(firstValue, x);
            }
            return firstValue;
        }
    }
}
