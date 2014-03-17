using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ManyFunctionTest
{
    using ManyFunction;
    [TestClass]
    public class ManyFunctionTest
    {
        [TestMethod]
        public void MapTest()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            List<int> result = ManyFunctionClass<int>.Map(list, x => x * 2);
            Assert.IsTrue(result[0] == 2 && result[1] == 4 && result[2] == 6);
        }

        [TestMethod]
        public void FilterTest()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            List<int> result = ManyFunctionClass<int>.Filter(list, x => (x % 3) == 0);
            Assert.IsTrue(result[0] == 3 && result.Count == 1);
        }

        [TestMethod]
        public void FoldTest()
        {
            List<int> list = new List<int> { 1, 2, 3, 4 };
            Assert.IsTrue(ManyFunctionClass<int>.Fold(list, 2, (ass, elem) => ass * elem) == 48);
        }
    }
}
