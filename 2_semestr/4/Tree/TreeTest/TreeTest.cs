using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TreeTest
{
    using Tree;

    [TestClass]
    public class TreeTest
    {
        [TestInitialize]
        public void Initialize()
        {
            myExpress = new CountingTree("(+ (/ 12 3) 12)");
        }

        [TestMethod]
        public void CountingTest()
        {
            Assert.IsTrue(myExpress.CountTree() == 16);
        }

        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void DivideByZeroExceptionTest()
        {
            CountingTree myExpress2 = new CountingTree("(+ (/ 12 0) 12)");
            myExpress2.CountTree();
        }

        [TestMethod]
        [ExpectedException(typeof(OtherSymbolException))]
        public void OtherSymbolExceptionTest()
        {
            CountingTree myExpress2 = new CountingTree("(+ (/ X 12) 12)");
            myExpress2.CountTree();
        }

        [TestMethod]
        [ExpectedException(typeof(MissedTokenException))]
        public void MissedTokenExceptionTest()
        {
            CountingTree myExpress2 = new CountingTree("( (/ 12 ) 12)");
            myExpress2.CountTree();
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyExpressionException))]
        public void EmptyExpressionExceptionTest()
        {
            CountingTree myExpress2 = new CountingTree("");
            myExpress2.CountTree();
        }

        [TestMethod]
        public void PrintTreeTest()
        {
            Assert.AreEqual(myExpress.PrintTree(), "(+ (/ 12 3) 12)");
        }

        CountingTree myExpress;
    }
}
