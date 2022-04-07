using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment1
{
    internal class StudentAverage
    {
        public static void Main(String[] args)
        {
            //Variable Declaration
            double[] sub = new double[5];
            int i;
            double sum = 0, avg;

            int len = sub.Length;
            

            //Variable Initialization
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Marks for Subjects");
                sub[i] = Convert.ToDouble(Console.ReadLine());
               
            }

            // Calculating Sum
            for (i = 0; i < 5; i++)
            {
                sum += sub[i];
            }

            // Calculating Average
            avg = sum / 5;

            Console.WriteLine("The average of all Subjects are : " + avg);

            Console.ReadKey();
        }
    }
}
