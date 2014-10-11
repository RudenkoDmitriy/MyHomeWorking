using System;
using Robots;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RobotsTest
{
    [TestClass]
    public class RobotsTest
    {
        [TestMethod]
        public void IsAllDestroyTest()
        {
            RobotsNetwork ourNetwork = new RobotsNetwork("..\\..\\test.txt");
            Assert.IsFalse(ourNetwork.IsAllRobotsDestroy());
            ourNetwork = new RobotsNetwork("..\\..\\test2.txt");
            Assert.IsTrue(ourNetwork.IsAllRobotsDestroy());
            ourNetwork = new RobotsNetwork("..\\..\\test3.txt");
            Assert.IsTrue(ourNetwork.IsAllRobotsDestroy());
        }

    }
}
