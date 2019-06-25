using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2905
{
    public class WorkCardApplication
    {
        public void WorkApplication()
        {
            BankAcc []cards = new BankAcc[3];
            CardAcc cardacc = new CardAcc(120000, "John1");
            Current current = new Current(150000, "John2");
            Deposite deposite = new Deposite(140000, "John3");

            cards[0] = cardacc;
            cards[1] = current;
            cards[2] = deposite;

            foreach (var item in cards)
            {
                Console.WriteLine(item.Balance);
                Console.WriteLine(item.Owner);
            }

        }
    }
}
