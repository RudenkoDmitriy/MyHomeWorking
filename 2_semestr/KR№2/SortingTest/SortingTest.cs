using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KR_2;

namespace SortingTest
{
    [TestClass]
    public class SortingTest
    {
        [TestMethod]
        public void IntSortTest()
        {
            int[] array = new int[] { 1, 2, 3, 4 , 4};
            Sorting.BubbleSort<int>(array, 5, new IntComapare());
            Assert.IsTrue(array[0] == 4 && array[1] == 4 && array[2] == 3 && array[3] == 2 && array[4] == 1);
        }
        [TestMethod]
        public void StringSortTest()
        {
            string[] array = new string[] { "a", "b", "v", "g" };
            Sorting.BubbleSort<string>(array, 4, new StringCompare());
            Assert.IsTrue((array[0] == "v") && (array[1] == "g") && (array[2] == "b") && (array[3] == "a"));
        }
    }
}
