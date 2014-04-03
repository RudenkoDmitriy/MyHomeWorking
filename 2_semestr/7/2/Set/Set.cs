using System;
using System.Collections;
using System.Collections.Generic;

namespace Set
{
    /// <summary>
    /// It's abstract type of data "Set". 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Set<T> : IEnumerable<T>
    {
        private HashSet<T> ourSet;
        public int Size 
        {
            get
            {
                return ourSet.Count;
            } 
        }

        public Set()
        {
            ourSet = new HashSet<T>();
        }

        /// <summary>
        /// Add element.
        /// </summary>
        /// <param name="value"></param>
        public void Add(T value)
        {
            ourSet.Add(value);
        }

        /// <summary>
        /// Remove element.
        /// </summary>
        /// <param name="value"></param>
        public bool Remove(T value)
        {
            return ourSet.Remove(value);
        }

        /// <summary>
        /// Check availability of element.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Contain(T value)
        {
            return ourSet.Contains(value);
        }

        /// <summary>
        /// Union of two input sets.
        /// </summary>
        /// <param name="firstMult"></param>
        /// <param name="secondMult"></param>
        /// <returns></returns>
        public static Set<T> Union(Set<T> firstMult, Set<T> secondMult)
        {
            Set<T> result = new Set<T>();
            foreach (var x in firstMult)
            {
                result.Add(x);
            }
            foreach (var x in secondMult)
            {
                if (!result.Contain(x))
                {
                    result.Add(x);
                }
            }
            return result;
        }

        /// <summary>
        /// Intersection of two sets.
        /// </summary>
        /// <param name="firstMult"></param>
        /// <param name="secondMult"></param>
        /// <returns></returns>
        public static Set<T> Intersection(Set<T> firstMult, Set<T> secondMult)
        {
            Set<T> result = new Set<T>();
            foreach (var x in firstMult)
            {
                if (secondMult.Contain(x))
                {
                    result.Add(x);
                }
            }
            return result;
        }

        /// <summary>
        /// Clear multiplicity.
        /// </summary>
        public void Clear()
        {
            ourSet.Clear();
        }

        /// <summary>
        /// Get enumenator
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return ourSet.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
