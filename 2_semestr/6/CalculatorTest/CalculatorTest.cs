using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestInitialize]
        public void Initialize()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void ResultTest()
        {
            Assert.IsTrue(calculator.Result() == 0);
        }

        [TestMethod]
        public void AddOperandTest()
        {
            calculator.AddOperand(10);
            Assert.IsTrue(calculator.Result() == 10);
        }

        [TestMethod]
        public void AddOperatorTest()
        {
            calculator.AddOperand(10);
            calculator.AddOperator("-");
            calculator.AddOperand(5);
            Assert.IsTrue(calculator.Result() == 5);
        }

        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void DivideByZeroExceptionTest()
        {
            calculator.AddOperand(10);
            calculator.AddOperator("/");
            calculator.AddOperand(0);
            calculator.Result();
        }

        [TestMethod]
        [ExpectedException(typeof(OtherTokenException))]
        public void OtherTokenExceptionTest()
        {
            calculator.AddOperator("ololo");
        }
        
        private Calculator calculator; 
    }
}
