using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class RobotsNetwork
    {
        private GraphOfNetwork Graph { get; set; }
        private bool[] ArrayOfRobots { get; set; }
        private EqualClassInGraph FirstClass { get; set; }
        private EqualClassInGraph SecondClass { get; set; }
        private bool[] visited { get; set; }

        /// <summary>
        /// Constructor of class.
        /// </summary>
        /// <param name="nameOfFile"></param>
        public RobotsNetwork(string nameOfFile)
        {
            ReadOut input = new ReadOut(nameOfFile);
            Graph = input.Graph;
            ArrayOfRobots = input.ArrayOfRobots;
            FirstClass = new EqualClassInGraph();
            SecondClass = new EqualClassInGraph();
            visited = new bool[Graph.NumberOfVertex];
            SeparationGraphOnEqualClass(0, true);
        }

        /// <summary>
        /// Separation graph on equal class.
        /// </summary>
        /// <param name="numberOfStartVertex"></param>
        /// <param name="isFirstClass"></param>
        private void SeparationGraphOnEqualClass(int numberOfStartVertex, bool isFirstClass)
        {
            if (isFirstClass)
            {
                if (ArrayOfRobots[numberOfStartVertex])
                {
                    FirstClass.AddRobot();
                }
            }
            else
            {
                if (ArrayOfRobots[numberOfStartVertex])
                {
                    SecondClass.AddRobot();
                }
            }
            visited[numberOfStartVertex] = true;
            for (int i = 0; i < Graph.NumberOfVertex; i++)
            {
                if (Graph.CheckEdge(numberOfStartVertex, i) && !visited[i])
                {
                    SeparationGraphOnEqualClass(i, !isFirstClass);
                }
            }
        }

        /// <summary>
        /// Check the destroy of robots.
        /// </summary>
        /// <returns></returns>
        public bool IsAllRobotsDestroy()
        {
            return FirstClass.IsCountEven() && SecondClass.IsCountEven();
        }
    }
}
