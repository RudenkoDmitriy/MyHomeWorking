using System;

namespace Stack
{
    public class Stack<T>
    {
        private ElementOfStack head;
        // Size of stack.
        private int size;
        // Stack's container.
        private class ElementOfStack
        {
            public T value;
            public ElementOfStack next;
        }

        public Stack()
        {
            head = null;
            size = 0;
        }

        // Push element to top.
        public void Push(T value)
        {
            ElementOfStack newElement = new ElementOfStack();
            newElement.value = value;
            newElement.next = head;
            head = newElement;
            size++;
        }

        // Delete element from top.
        public void Pop()
        {
            if (head != null)
            {
                this.head = this.head.next;
                size--;
            }
            else
            {
                throw new Exception();
            }
        }

        // Write element from top.
        public T Top()
        {
            if (head != null)
            {
                return head.value;
            }
            else
            {
                throw new Exception();
            }
        }

        // Clear stack.
        public void Clear()
        {
            while (size != 0)
            {
                Pop();
            }
            size = 0;
        }

        // Write stack(an optional feature).
        public void Write()
        {
            for (ElementOfStack temp = head; temp != null; temp = temp.next)
            {
                Console.Write("{0} ", temp.value);
            }
        }
    }

    class Program
    {
        // Example program.
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(3);
            stack.Push(2);
            stack.Write();
            stack.Clear();
            stack.Push(2);
            stack.Write();
        }
    }
}

