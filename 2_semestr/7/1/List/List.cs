using System;
using System.Collections;
using System.Collections.Generic;

namespace List
{
    public class MyList<T> : IEnumerable<T>
    {
        private ElementOfList Head {  get; set; }
        public int Size { get; private set; }

        /// <summary>
        /// List's container.
        /// </summary>
        private class ElementOfList
        {
            public T Value { get; set; }
            public ElementOfList Next { get; set; }
            public ElementOfList Back { get; set; }
            public ElementOfList(T value)
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
            var temp = Head;
            var newElement = new ElementOfList(value);
            newElement.Back = null;
            newElement.Next = temp;
            Head = newElement;
            if (Size != 0)
            {
                temp.Back = Head;
            }
            Size++;
        }

        /// <summary>
        /// Add element to last.
        /// </summary>
        /// <param name="value"></param>
        public void AddLast(T value)
        {
            if (Size == 0)
            {
                Add(value);
                return;
            }
            var temp = Head;
            for (int i = 1; i != Size; i++)
            {
                temp = temp.Next;
            }
            var newElement = new ElementOfList(value);
            newElement.Back = temp;
            newElement.Next = null;
            temp.Next = newElement;
            Size++;
        }

        /// <summary>
        /// Check availability of element.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Contain(T value)
        {
            for (var temp = Head; temp != null; temp = temp.Next)
            {
                if (Equals(temp.Value, value))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// List enumerator.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class ListEnumerator : IEnumerator<T>
        {
            private T curElement;
            private int curIndex;
            private MyList<T> curCollection;

            /// <summary>
            /// Return current value.
            /// </summary>
            public T Current { get { return curElement; } }

            object IEnumerator.Current { get { return Current; } }

            void IDisposable.Dispose() { }

            public ListEnumerator(MyList<T> list)
            {
                curElement = default(T);
                curIndex = -1;
                curCollection = list;
            }

            /// <summary>
            /// Move enumenator for next element and check end of list.
            /// </summary>
            /// <returns></returns>
            public bool MoveNext()
            {
                if (++curIndex >= curCollection.Size)
                {
                    return false;
                }
                else
                {
                    var temp = curCollection.Head;
                    for (int i = 0; i < curIndex; i++)
                    {
                        temp = temp.Next;
                    }
                    curElement = temp.Value;
                }
                return true;
            }

            /// <summary>
            /// Sets initial value.
            /// </summary>
            public void Reset()
            {
                curIndex = -1;
            }
        }

        /// <summary>
        /// Find index element by input value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int FindIndex(T value)
        {
            int count = 0;
            for (var temp = Head; temp != null; temp = temp.Next)
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
        /// Clear list.
        /// </summary>
        public void Clear()
        {
            Head = null;
            Size = 0;
        }

        /// <summary>
        /// Write list(an optional feature).
        /// </summary>
        /// <returns></returns>
        public string Write()
        {
            if (this.Head == null)
            {
                return "";
            }
            else
            {
                var temp = this.Head;
                string stringOfList = Convert.ToString(temp.Value);
                temp = temp.Next;
                while (temp != null)
                {
                    stringOfList += ", " + Convert.ToString(temp.Value);
                    temp = temp.Next;
                }
                return stringOfList;
            }
        }

        /// <summary>
        /// Return ListEnumerator for this list..
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return new ListEnumerator(this);
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
