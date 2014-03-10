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
        private string expression;
        private Node arithmTree;

        public CountingTree(string express)
        {
            expression = express;
            position = -1;
            arithmTree = BuildTree();
        }

        /// <summary>
        /// Create node depending on input token.
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private Node CreateNode(string token)
        {
            if (token[0] >= '0' && token[0] <= '9')
            {
                return new Operand(token);
            }
            if (token[0] == '-')
            {
                return new Substraction(token);
            }
            if (token[0] == '+')
            {
                return new Addition(token);
            }
            if (token[0] == '/')
            {
                return new Division(token);
            }
            if (token[0] == '*')
            {
                return new Multiplication(token);
            }
            throw new OtherSymbolException();
        }

        /// <summary>
        /// Create arithmetical tree.
        /// </summary>
        /// <returns></returns>
        public Node BuildTree()
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
                    if (expression[position] != '*' && expression[position] != '/' && expression[position] != '-' && expression[position] != '+')
                    {
                        throw new MissedTokenException();
                    }
                    Node newNode = CreateNode(Convert.ToString(expression[position]));
                    newNode.Left = BuildTree();
                    newNode.Right = BuildTree();
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
                    Node newNode = CreateNode(token);
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
