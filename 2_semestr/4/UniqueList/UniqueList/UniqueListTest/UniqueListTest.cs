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
        public void RemoveTest()
        {
            list.Add(2);
            list.Remove(3);
        }

        [TestMethod]
        [ExpectedException(typeof(DoubleAddingException))]
        public void AddTest()
        {
            list.Add(2);
            list.Add(2);
        }

        UniqueList<int> list;
    }
}
