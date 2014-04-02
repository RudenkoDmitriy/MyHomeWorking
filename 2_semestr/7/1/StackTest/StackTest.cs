using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack;

namespace StackTest
{
    [TestClass]
    public class StackTest
    {
        [TestInitialize]
        public void Initialize()
        {
            stack = new Stack<int>();
        }

        [TestMethod]
        public void PushTest()
        {
            stack.Push(3);
            Assert.IsTrue(stack.Size == 1);
        }

        [TestMethod]
        public void TopTest()
        {
            stack.Push(3);
            Assert.IsTrue(stack.Top() == 3);
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyStackException))]
        public void TopExceptionTest()
        {
            stack.Top();
        }

        [TestMethod]
        public void PopTest()
        {
            stack.Push(3);
            stack.Pop();
            Assert.IsTrue(stack.Size == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyStackException))]
        public void PopExceptionTest()
        {
            stack.Pop();
        }

        private Stack<int> stack; 
    }
}
