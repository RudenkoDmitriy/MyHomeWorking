namespace List
{
    using System;

    public class List<T>
    {
        private ElementOfList head;
        private int size;

        /// <summary>
        /// List's container.
        /// </summary>
        private class ElementOfList
        {
            public T value;
            public ElementOfList next;
            public ElementOfList back;
        }

        public List()
        {
            head = null;
            size = 0;
        }

        /// <summary>
        /// Add element to top.
        /// </summary>
        /// <param name="value"></param>
        public void Add(T value)
        {
            var temp = head;
            var newElement = new ElementOfList();
            newElement.value = value;
            newElement.back = null;
            newElement.next = temp;
            head = newElement;
            if (size != 0)
            {
                temp.back = head;
            }
            size++;
        }

        /// <summary>
        /// Add element to last.
        /// </summary>
        /// <param name="value"></param>
         public void AddRange(T value)
        {
            if (size == 0)
            {
                Add(value);
                return;
            }
            var temp = head;
            for (int i = 1; i != size; i++)
            {
                temp = temp.next;
            }
            var newElement = new ElementOfList();
            newElement.value = value;
            newElement.back = temp;
            newElement.next = null;
            temp.next = newElement;
            size++;
        }

        /// <summary>
        /// Insert element to input position.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="value"></param>
        public void Insert(int position, T value)
        {
            if (position < 0 || position >= size)
            {
                throw new Exception();
            }
            if (position == 0)
            {
                Add(value);
                return;
            }
            if (position == size)
            {
                AddRange(value);
                return;
            }
            var temp = head;
            while (position > 0)
            {
                temp = temp.next;
                position--;
            }
            var newElement = new ElementOfList();
            newElement.value = value;
            newElement.next = temp;
            newElement.back = temp.back;
            temp.back.next = newElement;
            temp.back = newElement;
            size++;
        }

        /// <summary>
        /// Remove element from input position.
        /// </summary>
        /// <param name="position"></param>
        public void RemoveAt(int position)
        {
            if (position < 0 || position >= size)
            {
                throw new Exception();
            }
            var temp = head;
            for (int i = 0; i < position; i++)
            {
                temp = head.next;
            }
            if (temp == head)
            {
                head = head.next;
                size--;
                return;
            }
            if (temp.next == null)
            {
                temp.back.next = null;
                size--;
                return;
            }
            temp.back.next = temp.next;
            temp.next.back = temp.back;
            size--;
        }

        /// <summary>
        /// Check availability of element.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Contain(T value)
        {
            for (var temp = head; temp != null; temp = temp.next)
            {
                if (Equals(temp.value, value))
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
            if (position < 0 || position >= size)
            {
                throw new Exception();
            }
            var temp = head;
            for (int i = 0; i < position; i++)
            {
                temp = temp.next;
            }
            return temp.value;
        }

        /// <summary>
        /// Find index element by input value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int FindIndex(T value)
        {
            int count = 0;
            for (var temp = head; temp != null; temp = temp.next)
            {
                if (Equals(temp.value, value))
                {
                    return count;
                }
                count++;
            }
            throw new Exception();
        }

        /// <summary>
        /// Clear list.
        /// </summary>
        public void Clear()
        {
            while (size != 0)
            {
                RemoveAt(0);
            }
        }

        /// <summary>
        /// Clear list.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return size;
        }

        /// <summary>
        /// Write stack(an optional feature).
        /// </summary>
        public string Write()
        {
            if (this.head == null)
            {
                throw new Exception();
            }
            else
            {
                var temp = this.head;
                string stringOfList = Convert.ToString(temp.value);
                temp = temp.next;
                while (temp != null)
                {
                    stringOfList += ", " + Convert.ToString(temp.value);
                    temp = temp.next;
                }
                return stringOfList;
            }
        }
    }
}
