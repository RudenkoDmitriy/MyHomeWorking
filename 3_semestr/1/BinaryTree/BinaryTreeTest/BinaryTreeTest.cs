using System;
using BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTreeTest
{
    [TestClass]
    public class BinaryTreeTest
    {
        [TestInitialize]
        public void Initialize()
        {
            tree = new BinaryTree<int>();
        }

        [TestMethod]
        public void FindTest()
        {
            Assert.IsFalse(tree.Find(3));
        }

        [TestMethod]
        public void AddTest()
        {
            tree.Add(3);
            Assert.IsTrue(tree.Find(3));
        }

        [TestMethod]
        public void DeleteTest()
        {
            Random rand = new Random();
            int number = rand.Next(1, 10);
            int forDelete = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i == number)
                {
                    forDelete = rand.Next(1, 10);
                    tree.Add(forDelete);
                    continue;
                }
                tree.Add(rand.Next(1, 10));
            }
            tree.Delete(forDelete);
            Assert.IsFalse(tree.Find(forDelete));
            /*tree.Add(50);
            tree.Add(20);
            tree.Add(19);
            tree.Add(21);
            tree.Add(18);
            tree.Add(100);
            //tree.Add(90);
            tree.Add(120);
            tree.Add(130);
            tree.Add(115);
            tree.Delete(50);
            Assert.IsFalse(tree.Find(50));*/    
        }

        [TestMethod]
        [ExpectedException(typeof(NoFindObjectException))]
        public void NoFindObjectExceptionTest()
        {
            tree.Add(3);
            tree.Delete(5);
        }

        [TestMethod]
        public void IteratorTest()
        {
            tree.Add(1);
            tree.Add(2);
            tree.Add(3);
            tree.Add(4);
            tree.Add(5);
            int result = 0;
            foreach (int value in tree)
            {
                result += value;
            }
            Assert.IsTrue(result == 15);
        }

        private BinaryTree<int> tree;
    }
}
