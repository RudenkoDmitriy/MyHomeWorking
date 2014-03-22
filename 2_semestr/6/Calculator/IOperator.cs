using System;

namespace Calc
{
    public interface IOperator
    {
        double Calculating(double firstOperand, double secondOperand);
    }
}
