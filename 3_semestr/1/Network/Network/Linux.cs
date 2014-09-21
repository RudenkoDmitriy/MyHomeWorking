using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// Class of OS Linux.
    /// </summary>
    public class Linux : OS
    {
        public override string Name { get; protected set; }
        public override double Probability { get; protected set; }

        /// <summary>
        /// Constructor for class.
        /// </summary>
        public Linux()
        {
            Name = "Linux";
            Probability = 67.3;
        }
    }
}
