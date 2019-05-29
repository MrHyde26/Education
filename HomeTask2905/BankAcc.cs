using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2905
{
    public class BankAcc
    {
        public double Balance { get; set; }

        public string Owner { get; set; }

        public BankAcc(double balance, string owner)
        {
            this.Balance = balance;
            this.Owner = owner;
        }

        public void CurrentBalance()
        {
            Console.WriteLine($"Current Balance: {this.Balance}");
        }

        public void CurrentOwner()
        {
            Console.WriteLine($"Current Owner: {this.Owner}");
        }

        public void AccountClosure(double amountWithdrawn)
        {
            this.Balance = 0;
            Console.WriteLine("Current Balance set to zero");
        }
    }
}
