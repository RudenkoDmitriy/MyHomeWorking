using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KR;

namespace XOTest
{
    [TestClass]
    public class XOTest
    {
        [TestInitialize]
        public void Initialize()
        {
            matrixOfGame = new GamePlace();
        }

        [TestMethod]
        public void ResultTest()
        {
            Assert.IsFalse(matrixOfGame.Result());
        }

        [TestMethod]
        public void AddTest()
        {
            matrixOfGame.Add(0, 0);
            matrixOfGame.Add(1, 1);
            matrixOfGame.Add(0, 1);
            matrixOfGame.Add(1, 2);
            matrixOfGame.Add(0, 2);
            Assert.IsTrue(matrixOfGame.Result());
        }

        [TestMethod]
        public void ClearTest()
        {
            matrixOfGame.Add(0, 0);
            matrixOfGame.Add(1, 1);
            matrixOfGame.Add(0, 1);
            matrixOfGame.Add(1, 2);
            matrixOfGame.Add(0, 2);
            Assert.IsTrue(matrixOfGame.numberOfEnterKeys == 5);
            matrixOfGame.Clear();
            Assert.IsFalse(matrixOfGame.Result());
            Assert.IsTrue(matrixOfGame.numberOfEnterKeys == 0);
        }

        private GamePlace matrixOfGame;
    }
}
