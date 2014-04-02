using System;

namespace Stack
{
    public class Stack<T>
    {
        private ElementOfStack head;

        /// <summary>
        /// Size of stack.
        /// </summary>
        public int Size { get; set; }

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
            Size = 0;
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
            Size++;
        }

        /// <summary>
        /// Delete element from top.
        /// </summary>
        public void Pop()
        {
            if (head != null)
            {
                this.head = this.head.Next;
                Size--;
            }
            else
            {
                throw new EmptyStackException();
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
                throw new EmptyStackException();
            }
        }

        /// <summary>
        /// Clear stack.
        /// </summary>
        public void Clear()
        {
            head = null;
            Size = 0;
        }
    }
}

