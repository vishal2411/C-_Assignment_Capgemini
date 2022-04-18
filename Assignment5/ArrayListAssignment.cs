using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class EmployeeManagement
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeSalaray { get; set; }
    }

    internal class ArrayListAssignment
    {

        public static void Main(String[] args)
        {
            ArrayList employees = new ArrayList()
        {
            new EmployeeManagement { EmployeeId = 101, EmployeeName = "John" , EmployeeSalaray = 50000 },
            new EmployeeManagement { EmployeeId = 102, EmployeeName = "Maxwell" , EmployeeSalaray = 2000 },
            new EmployeeManagement { EmployeeId = 103, EmployeeName = "Smriti" , EmployeeSalaray = 10000 },
            new EmployeeManagement { EmployeeId = 104, EmployeeName = "Yami" , EmployeeSalaray = 15000 }
        };

            foreach (EmployeeManagement employee in employees)
            {
                Console.WriteLine(employee.EmployeeId + " " + employee.EmployeeName + " " + employee.EmployeeSalaray);
            }

            Console.ReadKey();
        }

    }
}
