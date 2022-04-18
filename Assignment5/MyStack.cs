using System;
using System.Collections;

namespace Assignment5
{
    internal class MyStack
    {
        public static void Main(String[] args)
        {
            Stack myStack = new Stack();

            // Push Operation
            myStack.Push("101");
            myStack.Push("Tedi");
            myStack.Push("25000");

            // Display Output
            Console.WriteLine("Employee Details: ");
            foreach (Object obj in myStack)
                Console.WriteLine(obj);

            // Pop Operation
            myStack.Pop();


            // Display Output
            Console.WriteLine("\n Employee Details after Pop Operations:");
            foreach (Object obj in myStack)
                Console.WriteLine(obj);

            Console.ReadLine();
        }
    }
}
