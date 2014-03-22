using System;

namespace Calc
{
    /// <summary>
    /// Adding operator class.
    /// </summary>
    class Substraction : IOperator
    {
        public double Calculating(double firstOperand, double secondOperand)
        {
            return firstOperand - secondOperand;
        }
    }
}
