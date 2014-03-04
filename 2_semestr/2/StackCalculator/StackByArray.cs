namespace StackCalculator
{
    using System;
    class StackByArray<T> : IStack<T>
    {
        private T[] stack = new T[100];

        /// <summary>
        /// Size of stack.
        /// </summary>
        private int size;

        public StackByArray()
        {
            size = 0;
        }

        /// <summary>
        /// Push element to top.
        /// </summary>
        /// <param name="value"></param>
        public void Push(T value)
        {
            if (size + 1 > stack.Length)
            {
                Array.Resize(ref stack, stack.Length * 2);
            }
            stack[size] = value;
            size++;
        }

        /// <summary>
        /// Delete element from top.
        /// </summary>
        public void Pop()
        {
            if (size != 0)
            {
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
            if (size != 0)
            {
                return stack[size - 1];
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
            size = 0;
            Array.Clear(stack, 0, stack.Length);
        }

        /// <summary>
        /// Write stack(an optional feature).
        /// </summary>
        public void Write()
        {
            foreach (var temp in stack)
            {
                Console.Write("{0} ", temp);
            }
        }
    }
}
