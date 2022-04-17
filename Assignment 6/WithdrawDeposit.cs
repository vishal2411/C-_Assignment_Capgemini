using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDomain
{
    
    public class Account
    {
        public int AccNumber;
        public string CustomerName;
        public double Balance;

        public Account(int AccNumber,String CustomerName,double Balance)
        {
            /*this.AccNumber = (Convert.ToInt32(Console.ReadLine()));
            this.CustomerName = Console.ReadLine() ;
            this.Balance = Convert.ToDouble(Console.ReadLine());*/
            this.AccNumber = AccNumber;
            this.CustomerName = CustomerName;   
            this.Balance = Balance; 
        }
       

        public void Withdraw(double amount)
        {
            Console.WriteLine("Enter amount to withdraw");
            Console.ReadLine();
            //double amount;
            //amount = Convert.ToDouble(Console.ReadLine());

            if (this.Balance>500)
            {
                if(amount == 200 || amount == 500 || amount == 2000)
                {
                    Console.WriteLine(Balance + " : Rs is your Savings,Please choose Account to withdraw");
                    Console.WriteLine("1.Savings Account");
                    Console.WriteLine("2.Current Account");
                    Console.Read();
                    Console.WriteLine("Your transaction is processing...");
                    double finalbalance = Balance - amount;
                    Console.WriteLine(finalbalance + " : here is your balance after debiting the money, If not done by you please inform the local bank officials ");
                    Console.WriteLine("----------THANK YOU FOR AVAILING WITRHDRAW SERVICE-----------");
                }
                else
                {
                    Console.WriteLine("Oops!! something went wrong");
                }
                          
            }
            else if(Balance < 500)
            {
                Console.WriteLine("Your balance is less than 500rs sorry we cannot proceed");
            }
            else
            {
                Console.WriteLine("Your Session has been Expired!!");
            }
            
        }
        public void Deposit(double amt)
        {
            Console.WriteLine("Enter the amount you want to deposit ");
            Console.Read();
            if(amt >= 500)
            {
                Console.WriteLine("You have entered valid number, your amount will be deposited");
                Console.WriteLine("Thank you !! your deposition is successful");
                double dep = Balance + amt;
                Console.WriteLine(dep + ": Rs is your balance after the deposoition");
                Console.WriteLine("----------THANK YOU FOR AVAILING ATM DEPOSIT SERVICE-----------");
            }
            else if(amt < 500)  
            {
                Console.WriteLine("Please deposit more than 500 Rs");
            }
            else
            {
                Console.WriteLine("Invalid Number!!");
            }
        }
    }
    internal class WithdrawDeposit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------WELCOME TO THE BANKING APPLICATION DOMAIN----------");
            Console.ReadKey();
            Account ac1 = new Account(76548,"kishan kumar",5000000);
            ac1.Withdraw(500);
            
            //ac1.Deposit(500);
        }
    }
}
