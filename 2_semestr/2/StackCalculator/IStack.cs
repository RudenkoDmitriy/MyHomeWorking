namespace StackCalculator
{
    using System;
    /// <summary>
    /// Interface for stack.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IStack<T>
    {
        void Push(T value);
        void Pop();
        T Top();
        void Clear();
        void Write();
    }
}
