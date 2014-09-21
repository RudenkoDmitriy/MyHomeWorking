using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// Class of OS Windows.
    /// </summary>
    public class Windows : OS
    {
        public override string Name { get; protected set; }
        public override double Probability { get; protected set; }

        public Windows()
        {
            Name = "Windows";
            Probability = 10;
        }
    }
}
