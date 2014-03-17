using System;

namespace Tree
{
    /// <summary>
    /// "-" operator's class.
    /// </summary>
    public class Substraction : Operator
    {
        public override double Counting()
        {
            return Left.Counting() - Right.Counting();
        }

        public override string PrintToken()
        {
            return "-";
        }
    }
}
