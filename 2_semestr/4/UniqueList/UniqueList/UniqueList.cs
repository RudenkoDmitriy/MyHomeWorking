using System;
using System.Collections.Generic;

namespace UniqueList
{
    /// <summary>
    /// Unique list class. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class UniqueList<T> : List<T>
    {
        /// <summary>
        /// Reversed method "Add".
        /// </summary>
        /// <param name="value"></param>
        public void Add(T value)
        {
            if (this.Contains(value))
            {
                throw new DoubleAddingException();
            }
            else
            {
                base.Add(value);
            }
        }

        /// <summary>
        /// Reversed method "Remove".
        /// </summary>
        /// <param name="value"></param>
        public void Remove(T value)
        {
            if (!this.Contains(value))
            {
                throw new DeleteNotContainElementException();
            }
            else
            {
                base.Remove(value);
            }
        }
    }
}
