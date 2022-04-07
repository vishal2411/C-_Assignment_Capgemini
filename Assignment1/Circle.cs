using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment1
{
    internal class Circle
    {
        const double Pi = 3.14;
        public static void Main(String[] args)
        {
            double rad;

            Console.WriteLine("Enter Radius of a circle: ");
            rad = Convert.ToDouble(Console.ReadLine());

            Circle circle = new Circle();

            circle.Calculate(rad); 

        }
        void Calculate(double rad)
        {
            double area, circum;

            area = Pi * rad * rad;

            circum = 2 * Pi * rad;


            Console.WriteLine("The Area of the circle is : " + area);

            Console.WriteLine("The Circumference of circle is : " + circum);

            Console.ReadKey();
        }
    }
}
