using System;
using System.Collections.Generic;
using Network;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NetworkTest
{
    [TestClass]
    public class GraphOfNetworkTest
    {
        [TestInitialize]
        public void Initialize()
        {
            graph = new GraphOfNetwork(5);
        }

        [TestMethod]
        public void IsEdgeTest()
        {
            Assert.IsFalse(graph.CheckEdge(0, 4));
        }

        [TestMethod]
        public void CreateEdgeTest()
        {
            Assert.IsFalse(graph.CheckEdge(0, 4));
            graph.CreateEdge(0, 4);
            Assert.IsTrue(graph.CheckEdge(0, 4));
        }

        [TestMethod]
        public void CreateBSTQueue()
        {
            graph.CreateEdge(0, 1);
            graph.CreateEdge(0, 2);
            graph.CreateEdge(1, 3);
            graph.CreateEdge(1, 4);
            Queue<int> temp = graph.CreateBFSQueue();
            for (int i = 0; i < 5; i++)
            {
                Assert.IsTrue(temp.Dequeue() == i);
            }
        }

        private GraphOfNetwork graph;
    }
}
