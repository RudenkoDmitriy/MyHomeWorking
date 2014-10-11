using System;
using System.Collections.Generic;
using Robots;
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

        private GraphOfNetwork graph;
    }
}
