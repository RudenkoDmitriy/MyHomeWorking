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
            var temp = head;
            var newElement = new ElementOfList(value);
            newElement.Back = null;
            newElement.Next = temp;
            head = newElement;
            if (size != 0)
            {
                temp.Back = head;
            }
            size++;
        }

        /// <summary>
        /// Add element to last.
        /// </summary>
        /// <param name="value"></param>
        public void AddLast(T value)
        {
            if (size == 0)
            {
                Add(value);
                return;
            }
            var temp = head;
            for (int i = 1; i != size; i++)
            {
                temp = temp.Next;
            }
            var newElement = new ElementOfList(value);
            newElement.Back = temp;
            newElement.Next = null;
            temp.Next = newElement;
            size++;
        }

        /// <summary>
        /// Insert element to input position.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="value"></param>
        public void Insert(int position, T value)
        {
            if (position < 0 || position > size)
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
                AddLast(value);
                return;
            }
            var temp = head;
            while (position > 0)
            {
                temp = temp.Next;
                position--;
            }
            var newElement = new ElementOfList(value);
            newElement.Next = temp;
            newElement.Back = temp.Back;
            temp.Back.Next = newElement;
            temp.Back = newElement;
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
                temp = head.Next;
            }
            if (temp == head)
            {
                head = head.Next;
                size--;
                return;
            }
            if (temp.Next == null)
            {
                temp.Back.Next = null;
                size--;
                return;
            }
            temp.Back.Next = temp.Next;
            temp.Next.Back = temp.Back;
            size--;
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
            if (position < 0 || position >= size)
            {
                throw new Exception();
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
        public int FindIndex(T value)
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
            throw new Exception();
        }

        /// <summary>
        /// Clear list.
        /// </summary>
        public void Clear()
        {
            head = null;
            size = 0;
        }

        /// <summary>
        /// Return size of list.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return size;
        }

        /// <summary>
        /// Write list(an optional feature).
        /// </summary>
        /// <summary>
        public string Write()
        {
            if (this.head == null)
            {
                throw new Exception();
            }
            else
            {
                var temp = this.head;
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
    }
}
