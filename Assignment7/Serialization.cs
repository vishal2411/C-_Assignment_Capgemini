using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BinarySerializationProject
{
    
    public class Employee
    {
        public int empId = 101;
        public string empName = "kishan";
        public string empDesignation = "analystA4";

    }
    public class Manager1
    {
        public int managerId = 1001;
        public String managerName = "Snehal Pagare";
        public double managerBasicPayScale = 95000;

    }
    public class MarketingExecutive
    {
        public int markExId = 10001;
        public String markExName = "Johny Walker";
        public String markExDesignation = "BDA";

    }
    internal class Serialization
    {
        static void Main(String[] args)
        {
            //Serializing Manager Object
            Manager1 manager = new Manager1();
            FileStream fileStream = new FileStream(@"c:\Serialization1.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, manager);
            Console.ReadKey();

            //Serializing Employee Object
            Employee employee = new Employee();
            FileStream fileStream1 = new FileStream(@"c:\Serialization2.txt",FileMode.Create);
            BinaryFormatter formatter1 = new BinaryFormatter();
            formatter1.Serialize(fileStream, employee); 
            Console.ReadKey();

            //Serializing MarketingExecutive Object
            MarketingExecutive marketingExecutive = new MarketingExecutive();
            FileStream fileStream2 = new FileStream(@"c:\Serialization3.txt", FileMode.Create);
            BinaryFormatter formatter2 = new BinaryFormatter();
            formatter2.Serialize(fileStream2, marketingExecutive);
            Console.ReadKey();

        }
    }
}
