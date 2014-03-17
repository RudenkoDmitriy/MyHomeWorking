using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    /// <summary>
    /// "*" oprator's class.
    /// </summary>
    public class Multiplication : Operator
    {

        public override double Counting()
        {
            return Right.Counting() * Left.Counting();
        }

        public override string PrintToken()
        {
            return "*";
        }
    }
}
