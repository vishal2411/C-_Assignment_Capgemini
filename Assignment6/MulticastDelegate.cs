using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{

    public delegate void MarketingExecutiveDelegate();
    internal class MulticastDelegate
    {
        public static void Main(String[] args) {

            MarketingExecutive marketingExec = new MarketingExecutive();

            MarketingExecutiveDelegate marketingExecutiveDeleg = new MarketingExecutiveDelegate(marketingExec.printManagertDetails);

            marketingExecutiveDeleg += marketingExec.printMarketingExectDetails;

            marketingExecutiveDeleg.Invoke();

            Console.ReadKey();
        }
    }

    public class MarketingExecutive {

        private int managerID, marketingExecID;
        private string managerName, marketingExecExecName;
        private double managerSalary, marketingExecSalary;

        public MarketingExecutive() {
            Console.WriteLine("\n ---- Enter Manager Details ---- \n");

            Console.Write("Enter the Manager Id: ");
            this.managerID = (Convert.ToInt32(Console.ReadLine()));

            Console.Write("Enter the Manager Name : ");
            this.managerName = Console.ReadLine();

            Console.Write("Enter the Manager Salary : ");
            this.managerSalary = Convert.ToDouble(Console.ReadLine());

            //-------------Marketing Execuive Details ------------

            Console.WriteLine("\n --- Enter Marketing Eecutive Details ----\n");

            Console.Write("Enter the Marketing Executive Id: ");
            this.marketingExecID = (Convert.ToInt32(Console.ReadLine()));

            Console.Write("Enter the Marketing Executive Name : ");
            this.marketingExecExecName = Console.ReadLine();

            Console.Write("Enter the Marketing Executive Salary : ");
            this.marketingExecSalary = Convert.ToDouble(Console.ReadLine());
        }

        public void printManagertDetails()
        {
            Console.WriteLine("\n----- Manager Details --------\n");

            Console.WriteLine("Manager Id : {0}", managerID);
            Console.WriteLine("Manager Name : {0}", managerName);
            Console.WriteLine("Manager Salary : {0}", managerSalary);
        }

        public void printMarketingExectDetails()
        {
            Console.WriteLine("\n----- Marketing Details --------\n");

            Console.WriteLine("Marketing Executive Id : {0}", managerID);
            Console.WriteLine("Marketing Executive Name : {0}", managerName);
            Console.WriteLine("Marketing Executive Salary : {0}", managerSalary);
        }

    }
}
