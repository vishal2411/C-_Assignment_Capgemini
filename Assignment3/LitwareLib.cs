using Assignment3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class LitwareLib : IPrintable
    {
        static void Main(string[] args)
        {
            // Creating Object of Employee Class
            Employee employee = new Employee();
            Employee manager = new Manager();
            MarketingExecutive marketing = new MarketingExecutive();
            LitwareLib lib = new LitwareLib();

            // Variable Declaration
            int empNo;
            string empName;
            double empSalary;
            double kilometer;

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
            Console.WriteLine("\n---- Employee Details ----");
            Console.WriteLine("Emp no:" + employee.GetEmpNo());
            Console.WriteLine("Name:" + employee.GetEmpName());
            Console.WriteLine("Salary :" + employee.GetSalary());

            // Employee Gross & Net Salary
            lib.display(employee);

            // Manager Gross & Net Salary
            Console.WriteLine("\n ---- Manager Details ------");
            manager.calculateSalary(employee);
            lib.display(employee);

            // Marketing Executive Gross & Net Salary
            Console.WriteLine("\n---- Manager Details ------");

            Console.WriteLine("Enter Kilometer Travel : ");
            kilometer = Convert.ToDouble(Console.ReadLine());
            marketing.SetKilometer(kilometer);

            marketing.calculateSalary1(employee, marketing);
            lib.display(employee);

            Console.ReadKey();
        }

        public void display(Employee employee)
        {
            Console.WriteLine("Gross Salary :" + employee.GetGrossSalary());
            Console.WriteLine("Net Salary : " + employee.GetNetSalary());
        }
    }
}
