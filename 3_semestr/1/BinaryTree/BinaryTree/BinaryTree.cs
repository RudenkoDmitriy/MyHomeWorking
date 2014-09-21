using System;
using System.Collections;
using System.Collections.Generic;

namespace BinaryTree
{
    /// <summary>
    /// Class of binary tree.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinaryTree<T> : ITree<T>, IEnumerable<T>  where T : IComparable<T>
    {
        private Node Head { get; set; }

        /// <summary>
        /// Class of node in tree.
        /// </summary>
        private class Node
        {
            public T Value { get; set; }
            public Node LeftNode { get; set; }
            public Node RightNode { get; set; }
            public Node Parent { get; set; }

            public Node(T value)
            {
                this.Value = value;
            }
        }

        /// <summary>
        /// Add element in tree.
        /// </summary>
        /// <param name="value"></param>
        public void Add(T value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
            }
            AddInRecurs(ref newNode, Head);
        }

        /// <summary>
        /// Helping method for add.
        /// </summary>
        /// <param name="newNode"></param>
        /// <param name="nowPosition"></param>
        private void AddInRecurs(ref Node newNode, Node nowPosition)
        {
            if (newNode.Value.CompareTo(nowPosition.Value) == 1)
            {
                if (nowPosition.RightNode == null)
                {
                    newNode.Parent = nowPosition;
                    nowPosition.RightNode = newNode;
                    return;
                }
                AddInRecurs(ref newNode, nowPosition.RightNode);
                return;
            }
            if (newNode.Value.CompareTo(nowPosition.Value) == -1)
            {
                if (nowPosition.LeftNode == null)
                {
                    newNode.Parent = nowPosition;
                    nowPosition.LeftNode = newNode;
                    return;
                }
                AddInRecurs(ref newNode, nowPosition.LeftNode);
                return;
            }
        }

        /// <summary>
        /// Delete element from tree.
        /// </summary>
        /// <param name="value"></param>
        public void Delete(T value)
        {
            DeleteInRecurse(value, Head);
        }

        /// <summary>
        /// Helping method for delete.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="nowPosition"></param>
        private void DeleteInRecurse(T value, Node nowPosition)
        {
            if (value.CompareTo(nowPosition.Value) == 1)
            {
                if (nowPosition.RightNode == null)
                {
                    throw new NoFindObjectException();
                }
                DeleteInRecurse(value, nowPosition.RightNode);
                return;
            }
            if (value.CompareTo(nowPosition.Value) == -1)
            {
                if (nowPosition.LeftNode == null)
                {
                    throw new NoFindObjectException();
                }
                DeleteInRecurse(value, nowPosition.LeftNode);
                return;
            }
            if (value.CompareTo(nowPosition.Value) == 0)
            {
                if (nowPosition.LeftNode == null && nowPosition.RightNode == null)
                {
                    if (nowPosition == Head)
                    {
                        Head = null;
                        return;
                    }
                    if (nowPosition.Parent.LeftNode == nowPosition)
                    {
                        nowPosition.Parent.LeftNode = null;
                    }
                    else
                    {
                        nowPosition.Parent.RightNode = null;
                    }
                }
                if (nowPosition.LeftNode != null && nowPosition.RightNode == null)
                {
                    if (nowPosition == Head)
                    {
                        Head = Head.LeftNode;
                        return;
                    }
                    if (nowPosition.Parent.LeftNode == nowPosition)
                    {
                        nowPosition.Parent.LeftNode = nowPosition.LeftNode;
                    }
                    else
                    {
                        nowPosition.Parent.RightNode = nowPosition.LeftNode;
                    }
                    return;
                }
                if (nowPosition.LeftNode == null && nowPosition.RightNode != null)
                {
                    if (nowPosition == Head)
                    {
                        Head = Head.RightNode;
                        return;
                    }
                    if (nowPosition.Parent.LeftNode == nowPosition)
                    {
                        nowPosition.Parent.LeftNode = nowPosition.RightNode;
                    }
                    else
                    {
                        nowPosition.Parent.RightNode = nowPosition.RightNode;
                    }
                    return;
                }
                if (nowPosition.LeftNode != null && nowPosition.RightNode != null)
                {
                    if (nowPosition.RightNode.LeftNode == null)
                    {
                        nowPosition.RightNode.LeftNode = nowPosition.LeftNode;
                        if (nowPosition == Head)
                        {
                            Head = Head.RightNode;
                            return;
                        }
                        if (nowPosition.Parent.LeftNode == nowPosition)
                        {
                            nowPosition.Parent.LeftNode = nowPosition.RightNode;
                        }
                        else
                        {
                            nowPosition.Parent.RightNode = nowPosition.RightNode;
                        }
                        return;
                    }
                    Node temp = nowPosition.RightNode.LeftNode;
                    while (temp.LeftNode != null)
                    {
                        temp = temp.LeftNode;
                    }
                    nowPosition.Value = temp.Value;
                    if (temp.Parent.LeftNode == temp)
                    {
                        temp.Parent.LeftNode = null;
                    }
                    else
                    {
                        temp.Parent.RightNode = null;
                    }
                    return;
                }
            }
        }

        /// <summary>
        /// Find element in tree.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Find(T value)
        {
            return FindInRecurse(value, Head);
        }

        /// <summary>
        /// Helping method for find.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="nowPosition"></param>
        /// <returns></returns>
        private bool FindInRecurse(T value, Node nowPosition)
        {
            if (nowPosition == null)
            {
                return false;
            }
            if (value.CompareTo(nowPosition.Value) == -1)
            {
                return FindInRecurse(value, nowPosition.LeftNode);
            }
            if (value.CompareTo(nowPosition.Value) == 1)
            {
                return FindInRecurse(value, nowPosition.RightNode);
            }
            return true;
        }

        //Bonus!
        /*public IEnumerator<T> GetEnumerator()
        {
            Stack<Node> stack = new Stack<Node>();
            stack.Push(Head);
            while (stack.Count != 0)
            {
                Node temp = stack.Pop();
                if (temp.LeftNode != null)
                {
                    stack.Push(temp.LeftNode);
                }
                if (temp.RightNode != null)
                {
                    stack.Push(temp.RightNode);
                }
                yield return temp.Value;
            }
        }*/

        /// <summary>
        /// Tree enumerator.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class BinaryTreeEnumerator : IEnumerator<T>
        {
            private Node curElement;
            private BinaryTree<T> curCollection;
            private Stack<Node> stack;

            /// <summary>
            /// Return current value.
            /// </summary>
            public T Current { get { return curElement.Value; } }

            object IEnumerator.Current { get { return Current; } }

            void IDisposable.Dispose() { }

            public BinaryTreeEnumerator(BinaryTree<T> tree)
            {
                curCollection = tree;
                stack = new Stack<Node>();
                stack.Push(curCollection.Head);
            }

            /// <summary>
            /// Move enumenator for next element and check end of tree.
            /// </summary>
            /// <returns></returns>
            public bool MoveNext()
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                else
                {
                    curElement = stack.Pop();
                    if (curElement.LeftNode != null)
                    {
                        stack.Push(curElement.LeftNode);
                    }
                    if (curElement.RightNode != null)
                    {
                        stack.Push(curElement.RightNode);
                    }
                }
                return true;
            }

            /// <summary>
            /// Sets initial value.
            /// </summary>
            public void Reset()
            {
                stack.Clear();
                stack.Push(curCollection.Head);
            }
        }

        /// <summary>
        /// Return BinaryTreeEnumerator for this class.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return new BinaryTreeEnumerator(this);
        }

        /// <summary>
        /// GetEnumerator
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
