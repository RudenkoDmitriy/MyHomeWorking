using System;
using Network;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NetworkTest
{
    [TestClass]
    public class NetworkTest
    {
        [TestInitialize]
        public void Initialize()
        {
            ReadOut input = new ReadOut("..\\..\\test.txt");
            network = new Network.Network(input, 38);
        }

        [TestMethod]
        public void GetInformationTest()
        {
            string trueText = "0 Windows False\n1 MacOS False\n2 Linux False\n3 Linux False\n4 MacOS True\n";
            Assert.IsTrue(String.Compare(network.GetInformation(), trueText) == 0);

        }

        [TestMethod]
        public void OneTactTest()
        {
            network.OneTact();
            string trueText = "0 Windows False\n1 MacOS False\n2 Linux False\n3 Linux False\n4 MacOS True\n";
            Assert.IsTrue(String.Compare(network.GetInformation(), trueText) == 0);
            for (int i = 0; i < 3; i++)
            {
                network.OneTact();
            }
            string trueText2 = "0 Windows False\n1 MacOS False\n2 Linux True\n3 Linux False\n4 MacOS True\n";
            Assert.IsTrue(String.Compare(network.GetInformation(), trueText2) == 0);
        }

        private Network.Network network;
    }
}
