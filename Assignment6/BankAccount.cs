using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public delegate void AccountDelegate(int x);

    internal class BankAccount
    {
        public static void Main() {

            int withdrawAmt, depositAmt;
            String option;
            Account acc = new Account();

            acc.display();

            Console.WriteLine(" \n Select Option : Withdraw or Deposit");
            option = Console.ReadLine();

            if (option.Equals("Withdraw"))
            {
                Console.WriteLine("\nEnter Amount to be WithDrawn");
                withdrawAmt = Convert.ToInt32(Console.ReadLine());

                acc.UnderBalance += new AccountDelegate(acc.WithDraw);
                acc.InsufficientBalance(withdrawAmt);
            }

            else if (option.Equals("Deposit"))
            {
                Console.WriteLine("\n Enter Amount to be Deposit : ");
                depositAmt = Convert.ToInt32(Console.ReadLine());

                acc.ZeroBalance += new AccountDelegate(acc.Deposit);
                acc.DepositMoney(depositAmt);
            }

            else {
                Console.WriteLine("Invalid Option");
            }
            Console.ReadKey();
        }
    }

    public class Account {

        private int accNo;
        private string custName;
        private double balance;
        private double withdrawAmount;

        public event AccountDelegate UnderBalance;
        public event AccountDelegate ZeroBalance;

        public Account()
        {
            Console.WriteLine("Enter Account Number : ");
            this.accNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Customer Name: ");
            this.custName = Console.ReadLine();

            Console.WriteLine("Enter Initial Balance to Account: ");
            this.balance = Convert.ToDouble(Console.ReadLine());
        }

        public void display() {

            Console.WriteLine("\n ----Bank Details ----- \n");
            Console.WriteLine("Account Number is : " + accNo);
            Console.WriteLine("Customer Name is : "+ custName);
            Console.WriteLine("Current Balance is : " +balance);
        }

        public void InsufficientBalance(int x)
        {
            UnderBalance(x);
        }

        public void Deposit(int amount)
        {
            Console.Write("\nAccount Balance after deposit: " + (balance + amount));
        }

        public void WithDraw(int amount)
        {

            if (amount < balance && balance != 0)
            {
                Console.WriteLine(" \n Transaction Succesfull !!");
                Console.WriteLine("Remaining Balance is " + (balance - amount));
            }
            else if (amount > balance && balance != 0)
            {
                Console.WriteLine("\n You have insufficient amount");
                Console.WriteLine("Your Current Account Balance is " + balance + " only");
            }
            else
            {
                Console.WriteLine("\n Zero Balance :" + balance);
            }
        }
        public void DepositMoney(int amount)
        {
            ZeroBalance(amount);
        }
    }
}
