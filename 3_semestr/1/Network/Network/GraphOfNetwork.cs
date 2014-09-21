using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// Class of creating matrix of Network and array of computers, incoming in network.
    /// </summary>
    public class GraphOfNetwork
    {
        public int NumberOfVertex { get; private set; }

        public bool[,] Matrix { get; private set; }

        /// <summary>
        /// Constructor for class.
        /// </summary>
        /// <param name="numberOfVertex"></param>
        public GraphOfNetwork(int numberOfVertex)
        {
            this.NumberOfVertex = numberOfVertex;
            Matrix = new bool[numberOfVertex, numberOfVertex];
        }

        /// <summary>
        /// Create edge between first and second vertexes.
        /// </summary>
        /// <param name="firstVertex"></param>
        /// <param name="secondVertex"></param>
        public void CreateEdge(int firstVertex, int secondVertex)
        {
            if (firstVertex >= NumberOfVertex || secondVertex >= NumberOfVertex || firstVertex < 0 || secondVertex < 0)
            {
                throw new IncorrectInputDataException();
            }
            Matrix[firstVertex, secondVertex] = true;
            Matrix[secondVertex, firstVertex] = true;
        }

        /// <summary>
        /// Check existence edge between first and second vertex.
        /// </summary>
        /// <param name="firstVertex"></param>
        /// <param name="secondVertex"></param>
        /// <returns></returns>
        public bool CheckEdge(int firstVertex, int secondVertex)
        {
            return Matrix[firstVertex, secondVertex];
        }
    }
}
