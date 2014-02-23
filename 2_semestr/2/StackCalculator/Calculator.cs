using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculation
{
    interface IStack<T>
    {
        void Push(T value);
        void Pop();
        T Top();
        void Clear();
        void Write();
    }

    public class StackByPointer<T> : IStack<T>
    {
        private ElementOfStack head;
        // Size of stack.
        private int size;
        // Stack's container.
        private class ElementOfStack
        {
            public T value;
            public ElementOfStack next;
        }

        public StackByPointer()
        {
            head = null;
            size = 0;
        }

        // Push element to top.
        public void Push(T value)
        {
            ElementOfStack newElement = new ElementOfStack();
            newElement.value = value;
            newElement.next = head;
            head = newElement;
            size++;
        }

        // Delete element from top.
        public void Pop()
        {
            if (head != null)
            {
                this.head = this.head.next;
                size--;
            }
            else
            {
                throw new Exception();
            }
        }

        // Write element from top.
        public T Top()
        {
            if (head != null)
            {
                return head.value;
            }
            else
            {
                throw new Exception();
            }
        }

        // Clear stack.
        public void Clear()
        {
            while (size != 0)
            {
                Pop();
            }
        }

        // Write stack(an optional feature).
        public void Write()
        {
            for (ElementOfStack temp = head; temp != null; temp = temp.next)
            {
                Console.Write("{0} ", temp.value);
            }
        }
    }

    class StackByArray<T> : IStack<T>
    {
        private T[] stack = new T[1];
        private int size;

        public StackByArray()
        {
            size = 0;
        }

        // Push element to top.
        public void Push(T value)
        {
            stack[size] = value;
            size++;
            Array.Resize(ref stack, stack.Length + 1);
        }

        // Delete element from top.
        public void Pop()
        {
            if (size != 0)
            {
                size--;
            }
            else
            {
                throw new Exception();
            }
        }

        // Write element from top.
        public T Top()
        {
            if (size != 0)
            {
                return stack[size - 1];
            }
            else
            {
                throw new Exception();
            }
        }

        // Clear stack.
        public void Clear()
        {
            size = 0;
            Array.Clear(stack, 0, stack.Length);
        }

        // Write stack(an optional feature).
        public void Write()
        {
            foreach(var temp in stack)
            {
                Console.Write("{0} ", temp);
            }
        }
    }

    class Program
    {
        // Calculating expressio in postfix record.
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

        // Example program.
        // Test is positive with "1 2 + 2 3 - *".
        // Test is negative with "1 + 2"
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your expression in postfix record");
            string expression = Console.ReadLine();
            StackByArray<int> stack = new StackByArray<int>();
            Console.WriteLine("Is your answer: {0}", Calculate(stack, expression));
        }
    }
}
