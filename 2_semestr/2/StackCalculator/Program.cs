namespace StackCalculator
{
    using System;
    class Program
    {
        /// <summary>
        /// Calculating expression in postfix record.
        /// </summary>
        /// <param name="stack"></param>
        /// <param name="line"></param>
        /// <returns></returns>
        static int Calculate(IStack<int> stack, string line)
        {
            for (int i = 0; i != line.Length; i++)
            {
                char symbol = line[i];
                if (symbol != '-' && symbol != '*' && symbol != '/' && symbol != '+' && symbol != ' ')
                {
                    stack.Push(Convert.ToInt16(symbol) - 48);
                }
                else switch (symbol)
                    {
                        case '+':
                        {
                            int result = 0;
                            result += stack.Top();
                            stack.Pop();
                            result += stack.Top();
                            stack.Pop();
                            stack.Push(result);
                            break;
                        }
                        case '-':
                        {
                            int result = 0;
                            result -= stack.Top();
                            stack.Pop();
                            result += stack.Top();
                            stack.Pop();
                            stack.Push(result);
                            break;
                        }
                        case '*':
                        {
                            int result = 0;
                            result = 1;
                            result *= stack.Top();
                            stack.Pop();
                            result *= stack.Top();
                            stack.Pop();
                            stack.Push(result);
                            break;
                        }
                        case '/':
                        {
                            if (stack.Top() != 0)
                            {
                                int result = 0;
                                int temp = stack.Top();
                                stack.Pop();
                                result = stack.Top() / temp;
                                stack.Pop();
                                stack.Push(result);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Error: divide by ZeRo!!\n");
                                throw new Exception();
                            }
                        }
                        default:
                        {
                            continue;
                        }
                    }
            }
            int answer = stack.Top();
            stack.Pop();
            return answer;
        }

        /// <summary>
        /// Example program.
        /// Test is positive with "1 2 + 2 3 - *".
        /// Test is negative with "1 + 2"
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your expression in postfix record");
            string expression = Console.ReadLine();
            StackByArray<int> stack = new StackByArray<int>();
            Console.WriteLine("Is your answer: {0}", Calculate(stack, expression));
        }
    }
}
