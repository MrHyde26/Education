using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2905
{
    class Current : BankAcc
    {
        public Current(double balance, string owner)
            : base(balance, owner)
        {

        }

        public void Put(int sum)
        {
            this.Balance += sum;

            CurrentBalance();
        }

        public void Withdraw(int sum)
        {
            if (this.Balance >= sum)
            {
                this.Balance -= sum;
            }

            CurrentBalance();
        }
    }
}
