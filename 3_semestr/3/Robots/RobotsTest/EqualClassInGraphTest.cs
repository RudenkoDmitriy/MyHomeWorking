using System;
using Robots;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RobotsTest
{
    [TestClass]
    public class EqualClassInGraphTest
    {
        [TestInitialize]
        public void Initialize()
        {
            ourClass = new EqualClassInGraph();
        }

        [TestMethod]
        public void IsCountEvenTest()
        {
            Assert.IsTrue(ourClass.IsCountEven());
        }

        [TestMethod]
        public void AddRobotTest()
        {
            ourClass.AddRobot();
            Assert.IsFalse(ourClass.IsCountEven());
        }

        private EqualClassInGraph ourClass; 
    }
}
