using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniqueListTest
{
    using UniqueList;
    [TestClass]
    public class UniqueListTest
    {
        [TestInitialize]
        public void Initialize()
        {
            list = new UniqueList<int>();
        }

        [TestMethod]
        [ExpectedException(typeof(DeleteNotContainElementException))]
        public void RemoveAtTest()
        {
            list.Add(2);
            list.RemoveAt(3);
        }

        [TestMethod]
        [ExpectedException(typeof(DoubleAddingException))]
        public void AddTest()
        {
            list.Add(2);
            list.Add(2);
        }

        [TestMethod]
        [ExpectedException(typeof(DoubleAddingException))]
        public void InsertTest()
        {
            list.Insert(0, 2);
            list.Insert(1, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(DoubleAddingException))]
        public void AddLastTest()
        {
            list.AddLast(2);
            list.AddLast(2);
        }

        UniqueList<int> list;
    }
}
