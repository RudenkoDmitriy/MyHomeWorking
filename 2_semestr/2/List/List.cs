using System;

namespace List
{
    class Program
    {
        // Exmple program.
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            Console.WriteLine(list.Size());
            list.Write();
            list.Insert(3, 4);
            Console.WriteLine(list.FindIndex(4));
            list.RemoveAt(1);
            Console.WriteLine(list.ReturnByIndex(0));
            Console.WriteLine(list.Size());
            list.Write();

        }
    }

    public class List<T>
    {
        private ElementOfList head;
        private int size;

        // List's container.
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

        // Add element to top.
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

        // Add element to last.
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

        // Insert element to input position.
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
            if (position == size - 1)
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

        // Remove element from input position.
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
            }
            temp.back.next = temp.next;
            temp.next.back = temp.back;
            size--;
        }

        // Check availability of element.
        public bool Contain(T value)
        {
            for (var temp = head; temp != null; temp = temp.next)
            {
                if (Equals(temp.value, value))
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }

        // Return element by index.
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

        // Find index element by input value.
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

        // Clear list.
        public void Clear()
        {
            while (size != 0)
            {
                RemoveAt(0);
            }
        }

        // Return size of list.
        public int Size()
        {
            return size;
        }

        // Write stack(an optional feature).
        public void Write()
        {
            for (var temp = head; temp != null; temp = temp.next)
            {
                Console.Write("{0} ", temp.value);
            }
            Console.WriteLine();
        }
    }
}
