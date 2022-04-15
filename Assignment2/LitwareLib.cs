using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class LitwareLib
    {
        static void Main(string[] args)
        {
            // Creating Object of Employee Class
            Employee employee = new Employee();

            // Variable Declaration
            int empNo;
            string empName;
            double empSalary;

            // Variable Initialization
            Console.WriteLine("Enter Employee Number : ");
            empNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name : ");
            empName = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary: ");
            empSalary = Convert.ToDouble(Console.ReadLine());

            // Method Calling
            employee.SetEmpNo(empNo);
            employee.SetEmpName(empName);
            employee.SetSalary(empSalary);
            employee.calculateSalary(employee);

            // Display Output
            Console.WriteLine("Emp no:" + employee.GetEmpNo());
            Console.WriteLine("Name:" + employee.GetEmpName());
            Console.WriteLine("Salary :" + employee.GetSalary());
            Console.WriteLine("Gross Salary :" + employee.GetGrossSalary());

            Console.ReadKey();

        }
    }
}
