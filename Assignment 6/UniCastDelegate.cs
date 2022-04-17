using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniAndMultiCastDelegate
{
    public delegate void EmployeeDelegate(); //declaring Unicast delegate
    public class UniCastDelegate
    {

        /*static void Main(string[] args)
        {
            Manager manager = new Manager();


            EmployeeDelegate employeeDelegate = new EmployeeDelegate(manager.Display);


            employeeDelegate.Invoke();


        }*/
    }
    public class Manager
    {
        private int managerId;
        private string managerName;
        private string companyName;
        private string designation;
        private string workLocation;



        public Manager()
        {
            Console.Write("Enter the manager id : ");
            this.managerId = (Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter the manager name : ");
            this.managerName = Console.ReadLine();

            Console.Write("Enter the Company Name : ");
            this.companyName = Console.ReadLine();

            Console.Write("Enter the manager designation : ");
            this.designation = Console.ReadLine();

            Console.Write("Enter the manager WorkLocation : ");
            this.workLocation = Console.ReadLine();

        }

        public void Display()
        {
            Console.WriteLine("Manager Id : {0}", managerId);
            Console.WriteLine("Manager Name : {0}", managerName);
            Console.WriteLine("Manager Company Name : {0}", companyName);

            Console.WriteLine("Manager Designation : {0}", designation);

            Console.WriteLine("Manager Work Location : {0}", workLocation);
        }
    }
}
