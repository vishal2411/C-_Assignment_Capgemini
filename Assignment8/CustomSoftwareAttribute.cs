using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSoftwareAttribute
{
    [AttributeUsage(                 //this should be placed immediately before its target
    AttributeTargets.Class |
    AttributeTargets.Constructor |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Property,
    AllowMultiple = true)]

    public class SoftwareAttribute : System.Attribute  //Custom attribute
    {
        private String projectName;
        private String description;
        private String clientName;
        private String startedDate;
        private String endDate;

        
        public SoftwareAttribute(String Pn,String Dn,String Cn,String Sd,String Ed)
        {
            this.projectName = Pn;
            this.description = Dn;
            this.clientName = Cn;
            this.startedDate = Sd;
            this.endDate = Ed;
        }
        
        public String ProjectName
        {
            get { return this.projectName; }
        }
        public String Description
        {
            get { return this.description; }    
        }
        public String ClientName
        {
            get { return this.clientName; }
        }
        public String StartedDate
        {
            get { return this.startedDate; }
        }
        public String EndingDate
        {
            get { return this.endDate; }
        }

    }
    [SoftwareAttribute("Hs management", "about hospital", "v3 solns", "12 / 8 / 2012" ,"12/10/2013")]
    [SoftwareAttribute("Industry management", "about Industries", "v5 solns", "25 / 5 / 2016", "30/01/2020")]
    class HDFCAccount
    {
        //member variables
        protected int acNumber;
        protected String customerName;
        public HDFCAccount(int acNumber, String customerName)
        {
            this.acNumber = acNumber;
            this.customerName = customerName;
        }
        [SoftwareAttribute("Hs management", "about hospital", "v3 solns", "12 / 8 / 2012", "12/10/2013")]

        public int AcNumber
        {
            get
            {
                return this.acNumber;
            }
             
        }
        public String CustomerName
        {
            get { return this.customerName; }
        }

        public void DisplayHDFCAccountDetails()
        {
            Console.WriteLine("HDFC Account number : " + acNumber);
            Console.WriteLine("HDFC Customer Name : " + customerName);
            Console.ReadKey();
        }
        
    }
    [SoftwareAttribute("Hs management", "about hospital", "v3 solns", "12 / 8 / 2012", "12/10/2013")]
    [SoftwareAttribute("Industry management", "about Industries", "v5 solns", "25 / 5 / 2016", "30/01/2020")]
    public class ICICIAccount
    {
        public int iciciAcNumber;
        public String iciciCustomerName;

        public ICICIAccount(int iciciAcNumber,String iciciCustomerName)
        {
            this.iciciAcNumber = iciciAcNumber; 
            this.iciciCustomerName = iciciCustomerName; 
        }
        [SoftwareAttribute("Industry management", "about Industries", "v5 solns", "25 / 5 / 2016", "30/01/2020")]

        public int IciciAcNumber
        {
            get { return this.iciciAcNumber; }
        }
        public String  IciciCustomerName
        {
            get { return this.iciciCustomerName; }
        }
        public void DisplayICICIAccountDetails()
        {
            Console.WriteLine("ICICI Account Number :  " + iciciAcNumber);
            Console.WriteLine("ICICI Customer Name : " + iciciCustomerName);
        }

    }

    public class TestAttribute
    {
        static void Main(String[] args)
        {
            HDFCAccount hdfc = new HDFCAccount(674534245,"Vijay Mallya");
            hdfc.DisplayHDFCAccountDetails();
            Console.WriteLine("Please Press Enter to view ICICI Account Number : ");
            Console.ReadKey();
            ICICIAccount icici = new ICICIAccount(87542356, "Nirav Modi");
            icici.DisplayICICIAccountDetails();

            SoftwareAttribute customAttribute = new SoftwareAttribute("EMS", "it covers pf issues", "Infosys", "14/04/1995", "15/05/1999");

        }
    }
}


    
