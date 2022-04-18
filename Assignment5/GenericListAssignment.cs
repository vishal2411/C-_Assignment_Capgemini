using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class GenericListAssignment
    {
       public static void Main(String[] args)
        {
            List<string> employee = new List<string>();

            employee.Add("Maxwell");
            employee.Add("Smith");
            employee.Add("Henry");
            employee.Add("Tedi");

            Console.WriteLine("Employee Details are : ");
            foreach (var value in employee)
                Console.WriteLine(value);

            Console.WriteLine("\nTotal number of Employes are: " + employee.Count);
            Console.ReadLine();
        }
    }
}
