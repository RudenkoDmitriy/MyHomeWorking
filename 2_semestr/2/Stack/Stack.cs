using System;

namespace StackCalculator
{
    public class Stack<T>
    {
        private ElementOfStack head;

        /// <summary>
        /// Size of stack.
        /// </summary>
        private int size;

        /// <summary>
        /// Stack's container.
        /// </summary>
        private class ElementOfStack
        {
            public T Value { get; set; }
            public ElementOfStack Next { get; set; }
            public ElementOfStack(Stack<T> stack)
            {
                this.Next = stack.head;
            }
        }

        public Stack()
        {
            head = null;
            size = 0;
        }

        /// <summary>
        /// Push element to top.
        /// </summary>
        /// <param name="value"></param>
        public void Push(T value)
        {
            ElementOfStack newElement = new ElementOfStack(this);
            newElement.Value = value;
            head = newElement;
            size++;
        }

        /// <summary>
        /// Delete element from top.
        /// </summary>
        public void Pop()
        {
            if (head != null)
            {
                this.head = this.head.Next;
                size--;
            }
            else
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Write element from top.
        /// </summary>
        /// <returns></returns>
        public T Top()
        {
            if (head != null)
            {
                return head.Value;
            }
            else
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Clear stack.
        /// </summary>
        public void Clear()
        {
            head = null;
            size = 0;
        }

        /// <summary>
        ///  Write stack(an optional feature).
        /// </summary>
        public void Write()
        {
            for (ElementOfStack temp = head; temp != null; temp = temp.Next)
            {
                Console.Write("{0} ", temp.Value);
            }
        }
    }
}

