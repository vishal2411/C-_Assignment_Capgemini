using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment1
{
    internal class Calculator
    {
        static void Main(string[] args)
        {

            // Declaring variables
            int num1, num2;
            int sum;
            int diff;
            int multi;
            int div;

            // Initializing Variables
            Console.WriteLine("Enter value of num1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of num2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Addition
            sum = num1 + num2;

            // Subtraction
            diff = num2 - num1;

            //Multiplication
            multi = num1 * num2;

            //Division
            div = num1 / num2;

            Console.WriteLine("The sum of two numbers are : " + sum);
            Console.WriteLine("The difference of two numbers are : " + diff);
            Console.WriteLine("The multiplication of two numbers are :" + multi);
            Console.WriteLine("The division of two numbers are : " + div);
            Console.ReadKey();


        }
    }
}
