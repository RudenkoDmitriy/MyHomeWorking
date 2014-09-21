using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// Network's computer's class.
    /// </summary>
    public class Computer
    {
        public OS OS { get; set; }

        public bool Infected { get; set; }

        /// <summary>
        /// Check infection, if probability of infected exists.
        /// </summary>
        /// <param name="randomizer"></param>
        public void CheckInfection(Random randomizer)
        {
            if (randomizer.Next(1, 100) <= OS.Probability)
            {
                Infected = true;
            }
        }

        /// <summary>
        /// Constructor for class.
        /// </summary>
        /// <param name="OS"></param>
        /// <param name="infect"></param>
        public Computer(OS OS, bool infect)
        {
            this.OS = OS;
            Infected = infect;
        }
    }
}
