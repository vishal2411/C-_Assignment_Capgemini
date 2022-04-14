using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Stack
    {
        static readonly int MAX = 1000;
        int top;
        int[] stack = new int[MAX];

        public Stack()
        {
            top = -1;
        }

        bool IsEmpty()
        {
            return (top < 0);
        }

        internal bool Push(int values)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }

            else
            {
                stack[++top] = values;
                return true;
            }
        }

        internal int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }

            else
            {
                int data = stack[top--];
                return data;
            }
        }

        internal void DisplayStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are : ");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stack stack = new Stack();

                stack.Push(100);
                stack.Push(50);
                stack.Push(120);
                stack.Push(10);

                stack.DisplayStack();
                Console.WriteLine("-------------------------");

                Console.WriteLine("Item popped from Stack : {0}", stack.Pop());

                Console.WriteLine("-------------------------");
                stack.DisplayStack();

                Console.ReadKey();
            }
            catch (IndexOutOfRangeException index)
            {
                Console.WriteLine("Handled IndexOutOfRangeException in the Main method");
            }
        }
    }
}
