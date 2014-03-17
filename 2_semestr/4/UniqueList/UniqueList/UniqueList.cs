using System;
using List;

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
            if (this.Contain(value))
            {
                throw new DoubleAddingException();
            }
            else
            {
                base.Add(value);
            }
        }

        /// <summary>
        /// Reversed method "AddLast".
        /// </summary>
        /// <param name="value"></param>
        public void AddLast(T value)
        {
            if (this.Contain(value))
            {
                throw new DoubleAddingException();
            }
            else
            {
                base.AddLast(value);
            }
        }

        /// <summary>
        /// Reversed method "Insert".
        /// </summary>
        /// <param name="value"></param>
        public void Insert(int position, T value)
        {
            if (this.Contain(value))
            {
                throw new DoubleAddingException();
            }
            else
            {
                base.Insert(position, value);
            }
        }

        /// <summary>
        /// Reversed method "Remove".
        /// </summary>
        /// <param name="value"></param>
        public void RemoveAt(T value)
        {
            if (!this.Contain(value))
            {
                throw new DeleteNotContainElementException();
            }
            else
            {
                base.RemoveAt(base.FindIndex(value));
            }
        }
    }
}
