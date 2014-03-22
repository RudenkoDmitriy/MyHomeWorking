using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EventLoop;
using System.Windows.Input;

namespace EventLoopTest
{
    [TestClass]
    public class EventLoopTest
    {
        [TestInitialize]
        public void Initialize()
        {
            eventLoop = new CursorEventLoop();
            game = new CursorGame();   
        }

        [TestMethod]
        public void OnRightTest()
        {
            int position = Console.CursorLeft;
            game.OnRight(new object(), new EventArgs());
            Assert.IsTrue(position + 1 == Console.CursorLeft);
        }

        [TestMethod]
        public void OnDownTest()
        {
            int position = Console.CursorTop;
            game.OnDown(new object(), new EventArgs());
            Assert.IsTrue(position + 1 == Console.CursorTop);
        }

        [TestMethod]
        public void OnLeftTest()
        {
            int position = Console.CursorLeft;
            game.OnRight(new object(), new EventArgs());
            game.OnLeft(new object(), new EventArgs());
            Assert.IsTrue(position == Console.CursorLeft);
        }

        [TestMethod]
        public void OnUpTest()
        {
            int position = Console.CursorTop;
            game.OnDown(new object(), new EventArgs());
            game.OnUp(new object(), new EventArgs());
            Assert.IsTrue(position == Console.CursorTop);
        }

        private CursorGame game;
        private CursorEventLoop eventLoop;        
    }
}
