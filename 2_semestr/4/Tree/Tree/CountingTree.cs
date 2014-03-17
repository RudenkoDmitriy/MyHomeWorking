using System;

namespace Tree
{
    /// <summary>
    /// Main class in projeсt. Count arithmetical expresstion by arithmetical tree.
    /// Expression of the form, for example: (+(/4 2) 3)
    /// </summary>
    public class CountingTree
    {
        private int position;

        private Node arithmTree;

        public CountingTree(string expression)
        {
            position = -1;
            arithmTree = BuildTree(expression);
        }

        /// <summary>
        /// Create node depending on input token.
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private Operator CreateOperatorNode(string token)
        {
            if (token[0] == '-')
            {
                return new Substraction();
            }
            if (token[0] == '+')
            {
                return new Addition();
            }
            if (token[0] == '/')
            {
                return new Division();
            }
            if (token[0] == '*')
            {
                return new Multiplication();
            }
            throw new OtherSymbolException();
        }

        private Operand CreateOperandNode(string token)
        {
            return new Operand(token);
        }

        /// <summary>
        /// Create arithmetical tree.
        /// </summary>
        /// <returns></returns>
        private Node BuildTree(string expression)
        {
            while (expression.Length - 1 > position)
            {
                position++;
                while (expression[position] == ' ')
                {
                    position++;
                }
                string token = Convert.ToString(expression[position]);   
                if (token[0] == '(')
                {
                    position++;
                    while (expression[position] == ' ')
                    {
                        position++;
                    }
                    token = Convert.ToString(expression[position]);
                    if (token[0] != '*' && token[0] != '/' && token[0] != '-' && token[0] != '+')
                    {
                        throw new MissedTokenException();
                    }
                    var newNode = CreateOperatorNode(token);
                    newNode.Left = BuildTree(expression);
                    newNode.Right = BuildTree(expression);
                    return newNode; 
                }
                if (token[0] >= '0' && token[0] <= '9')
                {
                    position++;
                    while (expression[position] >= '0' && expression[position] <= '9')
                    {
                        token += expression[position];
                        position++;
                    }
                    var newNode = CreateOperandNode(token);
                    return newNode;
                }
                throw new OtherSymbolException();
            }
            throw new EmptyExpressionException();
        }

        /// <summary>
        /// Count expression by created tree.
        /// </summary>
        /// <returns></returns>
        public double CountTree()
        {
            return arithmTree.Counting();
        }

        /// <summary>
        /// Create string by expression.
        /// </summary>
        /// <returns></returns>
        public string PrintTree()
        {
            return arithmTree.Print();
        }
    }
}
