using System;
using System.Collections;
using System.Collections.Generic;

namespace Multiplicity
{
    public class IMultiplicityEnumerator<T> : IEnumerator<T>
    {
        private T curElement;
        private int curIndex;
        private Multiplicity<T> curCollection;

        /// <summary>
        /// Return current value.
        /// </summary>
        public T Current { get { return curElement; } }

        object IEnumerator.Current { get { return Current; } }

        void IDisposable.Dispose() { }

        public IMultiplicityEnumerator(Multiplicity<T> list)
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
                curElement = curCollection.ReturnByIndex(curIndex);
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
}
