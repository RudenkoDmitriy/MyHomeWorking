using System;

namespace Tree
{
    /// <summary>
    /// Class for operands(numbers).
    /// </summary>
    public class Operand : Node
    {
        public Operand(string token)
        {
            this.Value = token;
        }

        public override double Counting()
        {
            return Convert.ToInt32(Value);
        }

        public override string Print()
        {
            return this.Value;
        }
    }
}
