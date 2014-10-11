using System;
using System.IO;
using Robots;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NetworkTest
{
    [TestClass]
    public class ReadOutTest
    {
        [TestMethod]
        [ExpectedException(typeof(NotExistFileException))]
        public void ConstructReadOutTest()
        {
            ReadOut input = new ReadOut("ololo");
        }

        [TestMethod]
        [ExpectedException(typeof(IncorrectInputDataException))]
        public void IncorrectInputDataException()
        {
            ReadOut input = new ReadOut("..\\..\\testForIncorrectData.txt");
        }

    }
}
