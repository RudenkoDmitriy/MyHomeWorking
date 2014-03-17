using System;

namespace Tree
{
    /// <summary>
    /// View of operator's classes.
    /// </summary>
    public abstract class Operator : Node
    {
        public Node Left { get; set; }

        public Node Right { get; set; }

        public override string Print()
        {
            return "(" + PrintToken() + " " + this.Left.Print() + " " + this.Right.Print() + ")";
        }

        public abstract string PrintToken();
    }
}
