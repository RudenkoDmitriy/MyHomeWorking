using System;

namespace Calc
{
    /// <summary>
    /// Adding operator class.
    /// </summary>
    public class Adding : IOperator
    {
        public double Calculating(double firstOperand, double secondOperand)
        {
            return firstOperand + secondOperand;
        }
    }
}
