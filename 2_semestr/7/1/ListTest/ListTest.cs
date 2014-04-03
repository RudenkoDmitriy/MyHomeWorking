﻿namespace ListTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using List;

    [TestClass]
    public class ListTest
    {
        [TestInitialize]
        public void Initialize()
        {
            list = new MyList<int>();
        }

        [TestMethod]
        public void SizeTest()
        {
            Assert.IsTrue(list.Size == 0);
        }

        [TestMethod]
        public void FindIndexTest()
        {
            list.Add(0);
            Assert.IsTrue(list.FindIndex(0) == 0);
        }

        [TestMethod]
        public void AddTest()
        {
            list.Add(1);
            Assert.IsTrue(list.Size != 0);
            list.Add(0);
            Assert.IsTrue(list.FindIndex(0) == 0);
            Assert.IsTrue(list.FindIndex(1) == 1);
        }

        [TestMethod]
        public void ContainTest()
        {
            list.Add(1);
            Assert.IsTrue(list.Contain(1));
        }

        [TestMethod]
        public void AddRangeTest()
        {
            list.AddLast(1);
            list.AddLast(0);
            Assert.AreEqual(1, list.FindIndex(0));
            Assert.AreEqual(0, list.FindIndex(1));
        }


        [TestMethod]
        public void ClearTest()
        {
            list.Add(2);
            list.Add(0);
            list.Clear();
            Assert.IsTrue(list.Size == 0 && !list.Contain(1));
        }

        [TestMethod]
        public void WriteTest()
        {
            list.Add(2);
            list.Add(0);
            Assert.AreEqual<string>("0, 2", list.Write());
        }

        [TestMethod]
        [ExpectedException(typeof(NotContainElementException))]
        public void NotContainElementExceptionTest()
        {
            list.FindIndex(0);
        } 

        [TestMethod]
        public void ForeachTest()
        {
            int testResult = 0;
            list.Add(2);
            list.Add(1);
            list.Add(4);
            foreach (var x in list)
            {
                testResult += x;
            }
            Assert.IsTrue(testResult == 7);
        }

        private MyList<int> list;
    }
}
