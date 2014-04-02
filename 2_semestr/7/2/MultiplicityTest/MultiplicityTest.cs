using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Multiplicity;

namespace MultiplicityTest
{
    [TestClass]
    public class MultiplicityTest
    {
        [TestInitialize]
        public void Initialize()
        {
            multiplicity = new Multiplicity<int>();
        }

        [TestMethod]
        public void AddTest()
        {
            multiplicity.Add(3);
            multiplicity.Add(3);
            Assert.IsTrue(multiplicity.Size == 1);
        }

        [TestMethod]
        public void ContainTest()
        {
            multiplicity.Add(3);
            Assert.IsTrue(multiplicity.Contain(3));
        }

        [TestMethod]
        public void DeleteTest()
        {
            multiplicity.Add(3);
            multiplicity.Delete(3);
            Assert.IsFalse(multiplicity.Contain(3));
        }

        [TestMethod]
        [ExpectedException(typeof(NotContainElementException))]
        public void DeleteExceptionTest()
        {
            multiplicity.Delete(3);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ReturnByIndexExceptionTest()
        {
            multiplicity.ReturnByIndex(0);
        }

        [TestMethod]
        public void ReturnByIndexTest()
        {
            multiplicity.Add(3);
            Assert.IsTrue(multiplicity.ReturnByIndex(0) == 3);
        }

        [TestMethod]
        public void Clear()
        {
            multiplicity.Add(3);
            multiplicity.Clear();
            Assert.IsTrue(multiplicity.Size == 0);
        }

        [TestMethod]
        public void UnionTest()
        {
            var secondMultiplicity = new Multiplicity<int>();
            secondMultiplicity.Add(2);
            secondMultiplicity.Add(3);
            secondMultiplicity.Add(4);
            multiplicity.Add(4);
            multiplicity.Add(3);
            multiplicity.Add(1);
            var result = Multiplicity<int>.Union(multiplicity, secondMultiplicity);
            Assert.IsTrue(result.Contain(2) && result.Contain(3) && result.Contain(4) && result.Contain(1) && result.Size == 4); 
        }

        [TestMethod]
        public void IntersectionTest()
        {
            var secondMultiplicity = new Multiplicity<int>();
            secondMultiplicity.Add(2);
            secondMultiplicity.Add(3);
            secondMultiplicity.Add(4);
            multiplicity.Add(4);
            multiplicity.Add(3);
            multiplicity.Add(1);
            var result = Multiplicity<int>.Intersection(multiplicity, secondMultiplicity);
            Assert.IsTrue(!result.Contain(2) && result.Contain(3) && result.Contain(4) && !result.Contain(1) && result.Size == 2); 
        }

        private Multiplicity<int> multiplicity;
    }
}
