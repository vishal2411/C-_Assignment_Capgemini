using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class MarketingExecutive : Manager
    {

        private double kilometer;
        private double tourAllowance;
        private double teleAllowance;

        public void SetKilometer(double kilometer) { 
           this.kilometer = kilometer;
        
        }
        public double GetKilometer()
        {
            return kilometer; 
        }

        public void SetTourAllowance(double tourAllowance)
        {
            this.tourAllowance = tourAllowance;

        }
        public double GetTourAllowance()
        {
            return kilometer;
        }

        public void SetTeleAllowance(double teleAllowance)
        {
            this.teleAllowance = teleAllowance;

        }
        public double GetTeleAllowance()
        {
            return kilometer;
        }

        public void calculateSalary1(Employee employeedetails, MarketingExecutive marketing)
        {
          
            double tour = marketing.GetKilometer() * 5;
            double travel = 1000;

            double grossSalary = employeedetails.GetSalary() +
                                 employeedetails.GetHra() +
                                 employeedetails.GetDa() +
                                 employeedetails.GetTa() +
                                 tour + travel ;

            double pf = .1 * grossSalary;
            double tds = 0.18 * grossSalary;
            double netSalary = grossSalary - (tds);

            employeedetails.SetGrossSalary(grossSalary);
            employeedetails.SetNetSalary(netSalary);
        }
    }
}
