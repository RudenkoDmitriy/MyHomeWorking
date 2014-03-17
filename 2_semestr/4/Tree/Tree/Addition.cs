using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Addition : Operator
    {
        public override double Counting()
        {
            return Left.Counting() + Right.Counting();
        }

        public override string PrintToken()
        {
            return "+";
        }
    }
}
