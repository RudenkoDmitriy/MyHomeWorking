﻿using System;

namespace Tree
{
    /// <summary>
    /// "/" operator's class.
    /// </summary>
    public class Division : Operator
    {
        public Division(string token)
        {
            this.Value = token;
        }

        public override double Counting()
        {
            if (Right.Counting() == 0)
            {
                throw new DivideByZeroException();
            }
            return Left.Counting() / Right.Counting();
        }

        public override string PrintToken()
        {
            return "/";
        }
    }
}
