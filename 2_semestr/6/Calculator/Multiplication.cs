using System;

namespace Calc
{
    /// <summary>
    /// Multiplication operator class.
    /// </summary>
    class Multiplication : IOperator
    {
        public double Calculating(double firstOperand, double secondOperand)
        {
            return firstOperand * secondOperand;
        }
    }
}
