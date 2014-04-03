using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Set;

namespace SetTest
{
    [TestClass]
    public class SetTest
    {
        [TestInitialize]
        public void Initialize()
        {
            set = new Set<int>();
        }

        [TestMethod]
        public void AddTest()
        {
            set.Add(3);
            set.Add(3);
            Assert.IsTrue(set.Size == 1);
        }

        [TestMethod]
        public void ContainTest()
        {
            set.Add(3);
            Assert.IsTrue(set.Contain(3));
        }

        [TestMethod]
        public void DeleteTest()
        {
            set.Add(3);
            set.Remove(3);
            Assert.IsFalse(set.Contain(3));
            Assert.IsFalse(set.Remove(3));
        }

        [TestMethod]
        public void Clear()
        {
            set.Add(3);
            set.Clear();
            Assert.IsTrue(set.Size == 0);
        }

        [TestMethod]
        public void UnionTest()
        {
            var secondMultiplicity = new Set<int>();
            secondMultiplicity.Add(2);
            secondMultiplicity.Add(3);
            secondMultiplicity.Add(4);
            set.Add(4);
            set.Add(3);
            set.Add(1);
            var result = Set<int>.Union(set, secondMultiplicity);
            Assert.IsTrue(result.Contain(2) && result.Contain(3) && result.Contain(4) && result.Contain(1) && result.Size == 4); 
        }

        [TestMethod]
        public void IntersectionTest()
        {
            var secondMultiplicity = new Set<int>();
            secondMultiplicity.Add(2);
            secondMultiplicity.Add(3);
            secondMultiplicity.Add(4);
            set.Add(4);
            set.Add(3);
            set.Add(1);
            var result = Set<int>.Intersection(set, secondMultiplicity);
            Assert.IsTrue(!result.Contain(2) && result.Contain(3) && result.Contain(4) && !result.Contain(1) && result.Size == 2); 
        }

        private Set<int> set;
    }
}
