using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

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
            set { this.projectName = value; }
        }
        public String Description
        {
            get { return this.description; } 
            set { this.description = value; }
        }
        public String ClientName
        {
            get { return this.clientName; }
            set { this.clientName = value; }
        }
        public String StartedDate
        {
            get { return this.startedDate; }
            set { this.startedDate = value; }
        }
        public String EndingDate
        {
            get { return this.endDate; }
            set { this.endDate = value; }
        }

    }
    //[SoftwareAttribute("Hs management", "about hospital", "v3 solns", "12 / 8 / 2012" ,"12/10/2013")]
    //[SoftwareAttribute("Industry management", "about Industries", "v5 solns", "25 / 5 / 2016", "30/01/2020")]
    class HDFCAccount1 : SoftwareAttribute
    {
        //[SoftwareAttribute("Hs management", "about hospital", "v3 solns", "12 / 8 / 2012", "12/10/2013")]
        public void displayAccount(string projectName, string description, string clientname)
        {
            this.Description = description;
            this.ProjectName = projectName;
            this.ClientName = clientname;
            Console.WriteLine("Project Description : " + Description);
            Console.WriteLine("Projectname : " + ProjectName);
            Console.WriteLine("Project Client Name : " + ClientName);
        }
    }
       
        
    
    public class ICICIAccount1 : SoftwareAttribute
    {
        public void displayAccount(string description, string projectName, string clientname, string startdate, string enddate)
        {
            this.Description = description;
            this.ProjectName = projectName;
            this.ClientName = clientname;
            //this.StartedDate = startdate;
            //this.endDate = enddate;
            Console.WriteLine("\nProject Description : " + Description);
            Console.WriteLine("Projectname : " + ProjectName);
            Console.WriteLine("Project Client Name : " + ClientName);
            //Console.WriteLine("Project Started Date : " + StartedDate);
            //Console.WriteLine("Project End Date : \n" + EndDate);
        }

    }

    public class TestAttribute
    {
        static void Main(String[] args)
        {
            /*HDFCAccount hdfc = new HDFCAccount(674534245,"Vijay Mallya");
            hdfc.DisplayHDFCAccountDetails();
            Console.WriteLine("Please Press Enter to view ICICI Account Number : ");
            Console.ReadKey();
            ICICIAccount icici = new ICICIAccount(87542356, "Nirav Modi");
            icici.DisplayICICIAccountDetails();*/
            HDFCAccount1 ha = new HDFCAccount1();
            ha.displayAccount("reflection assignment", "reflection", "capgemini");
            ICICIAccount1 ia = new ICICIAccount1();
            ia.displayAccount("reflection assignment", "reflection", "capgemini", "17-04-2022", "18-04-2022");



            Assembly executing = Assembly.GetExecutingAssembly();
            Type[] types = executing.GetTypes();
            foreach (Type t in types)
            {
                MethodInfo[] mi = t.GetMethods();
                foreach (var m in mi)
                {
                    Console.WriteLine(m);
                }
            }

        }

    }

}


    
