using System;
using System.Collections.Generic;

namespace BinaryTree
{
    /// <summary>
    /// Interface for tree.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface ITree<T> 
    {
        void Add(T value);

        void Delete(T value);

        bool Find(T value);
    }
}
