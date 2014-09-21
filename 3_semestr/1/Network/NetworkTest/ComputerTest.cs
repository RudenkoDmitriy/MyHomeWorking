using System;
using Network;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NetworkTest
{
    [TestClass]
    public class ComputerTest
    {
        [TestMethod]
        public void CheckInfectedTest()
        {
            Computer comp = new Computer(new Windows(), false);
            Random rand = new Random(1);
            for (int i = 0; i < 10; i++)
            {
                comp.CheckInfection(rand);
            }
            Assert.IsFalse(comp.Infected);
            comp.CheckInfection(rand);
            Assert.IsTrue(comp.Infected);
        }
    }
}
