using System;

namespace Tree
{
    /// <summary>
    /// "-" operator's class.
    /// </summary>
    public class Substraction : Operator
    {
        public Substraction(string token)
        {
            this.Value = token;
        }

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
