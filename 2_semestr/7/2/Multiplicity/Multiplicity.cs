using System;
using System.Collections;
using System.Collections.Generic;

namespace Multiplicity
{
    public class Multiplicity<T> : IEnumerable<T>
    {
        private ElementOfMultiplicity head;
        public int Size { get; set; }

        /// <summary>
        /// Multiplicity's container.
        /// </summary>
        private class ElementOfMultiplicity
        {
            public T Value { get; set; }
            public ElementOfMultiplicity Next { get; set; }
            public ElementOfMultiplicity Back { get; set; }
            public ElementOfMultiplicity(T value)
            {
                Value = value;
            }
        }

        /// <summary>
        /// Add element to top.
        /// </summary>
        /// <param name="value"></param>
        public void Add(T value)
        {
            if (this.Contain(value))
            {
                return;
            }
            var temp = head;
            var newElement = new ElementOfMultiplicity(value);
            newElement.Back = null;
            newElement.Next = temp;
            head = newElement;
            if (Size != 0)
            {
                temp.Back = head;
            }
            Size++;
        }

        /// <summary>
        /// Remove element from input position.
        /// </summary>
        /// <param name="position"></param>
        private void RemoveAt(int position)
        {
            if (position < 0 || position >= Size)
            {
                throw new IndexOutOfRangeException();
            }
            var temp = head;
            for (int i = 0; i < position; i++)
            {
                temp = head.Next;
            }
            if (temp == head)
            {
                head = head.Next;
                Size--;
                return;
            }
            if (temp.Next == null)
            {
                temp.Back.Next = null;
                Size--;
                return;
            }
            temp.Back.Next = temp.Next;
            temp.Next.Back = temp.Back;
            Size--;
        }

        /// <summary>
        /// Delete element.
        /// </summary>
        /// <param name="value"></param>
        public void Delete(T value)
        {
            RemoveAt(this.FindIndex(value));
        }

        /// <summary>
        /// Check availability of element.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Contain(T value)
        {
            for (var temp = head; temp != null; temp = temp.Next)
            {
                if (Equals(temp.Value, value))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Return element by index.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public T ReturnByIndex(int position)
        {
            if (position < 0 || position >= Size)
            {
                throw new IndexOutOfRangeException();
            }
            var temp = head;
            for (int i = 0; i < position; i++)
            {
                temp = temp.Next;
            }
            return temp.Value;
        }

        /// <summary>
        /// Find index element by input value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private int FindIndex(T value)
        {
            int count = 0;
            for (var temp = head; temp != null; temp = temp.Next)
            {
                if (Equals(temp.Value, value))
                {
                    return count;
                }
                count++;
            }
            throw new NotContainElementException();
        }

        /// <summary>
        /// Union of two input multiplicity.
        /// </summary>
        /// <param name="firstMult"></param>
        /// <param name="secondMult"></param>
        /// <returns></returns>
        public static Multiplicity<T> Union(Multiplicity<T> firstMult, Multiplicity<T> secondMult)
        {
            Multiplicity<T> result = new Multiplicity<T>();
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
        /// Intersection of two multiplicity.
        /// </summary>
        /// <param name="firstMult"></param>
        /// <param name="secondMult"></param>
        /// <returns></returns>
        public static Multiplicity<T> Intersection(Multiplicity<T> firstMult, Multiplicity<T> secondMult)
        {
            Multiplicity<T> result = new Multiplicity<T>();
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
            head = null;
            Size = 0;
        }

        /// <summary>
        /// Return IListEnumerator for this list..
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return new IMultiplicityEnumerator<T>(this);
        }

        /// <summary>
        /// GetEnumerator
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

