namespace ListTest
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
            list = new List<int>();
        }

        [TestMethod]
        public void SizeTest()
        {
            Assert.IsTrue(list.Size() == 0);
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
            Assert.IsTrue(list.Size() != 0);
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
        public void InsertTest()
        {
            list.Add(2);
            list.Add(0);
            list.Insert(1, 1);
            Assert.IsTrue(list.FindIndex(1) == 1 && list.FindIndex(0) == 0 && list.FindIndex(2) == 2);
        }

        [TestMethod]
        public void RemoveAtTest()
        {
            list.Add(2);
            list.Add(0);
            list.Insert(1, 1);
            list.RemoveAt(1);
            Assert.IsTrue(list.FindIndex(2) == 1);
            list.RemoveAt(1);
            Assert.IsTrue(list.FindIndex(0) == 0);
        }

        [TestMethod]
        public void ReturnByIndexTest()
        {
            list.Add(2);
            list.Add(0);
            list.Insert(1, 1);
            list.AddLast(5);
            Assert.IsTrue(list.ReturnByIndex(3) == 5);
        }

        [TestMethod]
        public void ClearTest()
        {
            list.Add(2);
            list.Add(0);
            list.Insert(1, 1);
            list.Clear();
            Assert.IsTrue(list.Size() == 0 && !list.Contain(1));
        }

        [TestMethod]
        public void WriteTest()
        {
            list.Add(2);
            list.Add(0);
            list.Insert(1, 1);
            Assert.AreEqual<string>("0, 1, 2", list.Write());
        }

        private List<int> list;
    }
}
