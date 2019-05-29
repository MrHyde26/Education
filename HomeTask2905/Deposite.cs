using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2905
{
    public class Deposite:BankAcc
    {
        public double Percent { get; set; }

        public Deposite(double balance, string owner)
            : base(balance, owner)
        {
            
        }

        public void InterestAccrual()
        {
            this.Balance += this.Balance * (this.Percent / 100);
            CurrentBalance();
        }

        public void SettingPercent(double percent)
        {
            this.Percent = percent;
        }
    }
}
