using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BinarySerializationProject
{
    public class Manager
    {
        public int managerId = 101;
        public string managerName = "Snehal Pagare";
        public double managerBasicSalary = 95000;
    }


    internal class BinarySerializer 
    {
        static void Main(string[] args)
        {
            //Binary Serialization
            Manager manager = new Manager();
            FileStream fileStream = new FileStream(@"c:\BinarySerialization.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, manager); //serialization using Serialize() method
            Console.ReadKey();

            //Binary Deserialization using Deserialize() method
            Manager managerAskingToDesialize = (Manager) formatter.Deserialize(fileStream);
            Console.WriteLine(managerAskingToDesialize.managerId);
            Console.WriteLine(managerAskingToDesialize.managerName);
            Console.WriteLine(managerAskingToDesialize.managerBasicSalary);
            Console.ReadKey();

        }
    }
}
