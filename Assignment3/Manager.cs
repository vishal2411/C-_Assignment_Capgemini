using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Manager: Employee
    {
        // Private Variable Declaration
        private double petrolAllowance;
        private double foodAllowance;
        private double otherAllowance;

        public double GetPetrolAllowance()
        {
            return petrolAllowance;
        }
        public void SetPetrolAllowance(double value)
        {
            this.petrolAllowance = value;
        }

        public double GetFoodAllowance()
        {
            return foodAllowance;
        }
        void SetFoodAllowance(double value)
        {
            this.foodAllowance = value;
        }

        public double GetOtherAllowance()
        {
            return otherAllowance;
        }
        void SetOtherAllowance(double value)
        {
            this.otherAllowance = value;
        }

        public override void calculateSalary(Employee employeedetails) {

            double petrol = calculatePetrol(employeedetails.GetSalary());
            double food = calculateFood(employeedetails.GetSalary());
            double other = calculateOther(employeedetails.GetSalary());

            double grossSalary = employeedetails.GetSalary() +
                                 employeedetails.GetHra() + 
                                 employeedetails.GetDa() +
                                 employeedetails.GetTa() +
                                 petrol + food + other;

            double pf = .1 * grossSalary;
            double tds = 0.18 * grossSalary;
            double netSalary = grossSalary - (tds);

            employeedetails.SetGrossSalary(grossSalary);
            employeedetails.SetNetSalary(netSalary);
        }

        double calculatePetrol(double salary)
        {
            return 0.08 * salary;
        }

        double calculateFood(double salary)
        {
            return 0.08 * salary;
        }

        double calculateOther(double salary)
        {
            return 0.08 * salary;
        }
    }

}
