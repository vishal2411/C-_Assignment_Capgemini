using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment1
{
    internal class SwapProgram
    {
        public static void Main(String[] args)
        {
            int num1, num2;

            Console.WriteLine("------ Before Swapping ------");

            Console.WriteLine("Enter Number1: ");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Number2");
            num2 = Convert.ToInt16(Console.ReadLine());

            SwapProgram swapprogram = new SwapProgram();

            swapprogram.Swap(num1, num2);
        }
        void Swap(int num1, int num2)
        {
            int temp;

            temp = num1;
            num1 = num2;
            num2 = temp;


            Console.WriteLine("--------- After Swapping --------");

            Console.WriteLine("Number 1 : " + num1);
            Console.WriteLine("Number 2 : " + num2);

            Console.ReadKey();
        }

    }
}
