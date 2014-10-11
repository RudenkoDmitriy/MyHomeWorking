using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class EqualClassInGraph
    {
        private int CountOfRobots { get; set; }

        /// <summary>
        /// Add robot in class.
        /// </summary>
        public void AddRobot()
        {
            CountOfRobots++;
        }

        /// <summary>
        /// Check events count of robots.SS
        /// </summary>
        /// <returns></returns>
        public bool IsCountEven()
        {
            return CountOfRobots % 2 == 0;
        }
    }
}
