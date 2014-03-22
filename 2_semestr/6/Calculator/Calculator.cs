using System;

namespace Calc
{
    /// <summary>
    /// Calculator class.
    /// </summary>
    public class Calculator 
    {
        public double FirstOperand { get; set; }
        private bool TestOnFirstOperand { get; set; }
        public double SecondOperand { get; set; }
        private bool TestOnSecondOperand { get; set; }
        public IOperator Operator { get; set; }

        /// <summary>
        /// Constractor for calculator.
        /// </summary>
        public Calculator()
        {
            TestOnFirstOperand = false;
            TestOnSecondOperand = false;
        }

        /// <summary>
        /// Add operand.
        /// </summary>
        /// <param name="operand"></param>
        public void AddOperand(double operand)
        {
            if (!TestOnFirstOperand)
            {
                FirstOperand = operand;
                TestOnFirstOperand = true;
            }
            else
            {
                SecondOperand = operand;
                TestOnSecondOperand = true;
            }
        }

        /// <summary>
        /// Add operator.
        /// </summary>
        /// <param name="operation"></param>
        public void AddOperator(string operation)
        {
            if (TestOnFirstOperand && TestOnSecondOperand)
            {
                FirstOperand = Operator.Calculating(FirstOperand, SecondOperand);
                TestOnSecondOperand = false;
                Operator = ChoiseOperator(operation);
            }
            else
            {
                Operator = ChoiseOperator(operation);
            }
        }

        /// <summary>
        /// Choise class of oprator by input symbol.
        /// </summary>
        /// <param name="operation"></param>
        /// <returns></returns>
        private IOperator ChoiseOperator(string operation)
        {
            if (operation == "*")
            {
                return new Multiplication();
            }
            if (operation == "+")
            {
                return new Adding();
            }
            if (operation == "-")
            {
                return new Substraction();
            }
            if (operation == "/")
            {
                return new Division();
            }
            throw new OtherTokenException();
        }

        /// <summary>
        /// Counting result.
        /// </summary>
        /// <returns></returns>
        public double Result()
        {
            if (!TestOnSecondOperand)
            {
                Clear();
                return FirstOperand;
            }
            else 
            {
                FirstOperand = Operator.Calculating(FirstOperand, SecondOperand);
                Clear();
                return FirstOperand;
            }
        }

        /// <summary>
        /// Clear information in calculator.
        /// </summary>
        public void Clear()
        {
            TestOnFirstOperand = false;
            TestOnSecondOperand = false;
        }
    }
}
