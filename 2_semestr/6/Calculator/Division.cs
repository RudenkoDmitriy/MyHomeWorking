using System;

namespace Calc
{
    /// <summary>
    /// Division operator class.
    /// </summary>
    class Division : IOperator
    {
        public double Calculating(double firstOperand, double secondOperand)
        {
            if (secondOperand == 0)
            {
                throw new DivideByZeroException();
            }
            return firstOperand / secondOperand;
        }
    }
}
