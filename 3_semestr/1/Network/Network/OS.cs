using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// Abstract class for all OS.
    /// </summary>
    public abstract class OS
    {
        public abstract string Name { get; protected set; }

        public abstract double Probability { get; protected set; }
    }
}
