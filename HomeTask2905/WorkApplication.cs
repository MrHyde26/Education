using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2905
{
    public class WorkApplication
    {
        public void Main()
        {
            bool exitBankAcc=true;
            bool exitAcc = true;
            bool exitWorkWithAcc = true;
            int i = 0;
            int index = 0;
            
            BankAcc[] bankAcc = new BankAcc[5];

            do
                {
                    for (i = 0; i < bankAcc.Length; i++)
                    {
                        
                        do
                        {
                            Console.WriteLine("Enter type of bank account (card, deposite, current)");
                            string cardAcc = Console.ReadLine();
                            Console.WriteLine("Enter balance of bank account");
                            double balance = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter owner of bank account");
                            string owner = Console.ReadLine();

                            switch (cardAcc)
                            {
                                case "card":
                                    bankAcc[i] = new CardAcc(balance, owner);
                                exitBankAcc = false;
                                    break;
                                case "deposite":
                                    bankAcc[i] = new Deposite(balance, owner);
                                exitBankAcc = false;
                                    break;
                                case "current":
                                    bankAcc[i] = new Current(balance, owner);
                                exitBankAcc = false;
                                    break;
                                default:
                                    Console.WriteLine("Invalid data");
                                    break;
                            }
                    } while (exitBankAcc == true);

                    Console.WriteLine("Enter Y to continue or any other key for work with the accounts");
                        string exitCreateAcc = Console.ReadLine();

                        if (exitCreateAcc == "Y" || i == 4)
                        {
                            index = i;
                            exitAcc = false;
                        break;
                        }
                    
                }
                    
            } while (exitAcc == true);
            do
                {
                Console.WriteLine("Enter what do you mean: Withdraw bank account (withdraw) " +
                    "or charge interest and withdraw bank account (charge)");
                string workWithAcc =Console.ReadLine();

                if (workWithAcc == "withdraw")
                {
                    for (int j = -1; j <= index-1; j++)
                    {
                        bankAcc[j+1].CurrentOwner();
                        bankAcc[j+1].CurrentBalance();
                    }
                }
                else if (workWithAcc == "charge")
                {
                    Console.WriteLine("Enter percent");
                    double percent = Convert.ToDouble(Console.ReadLine());

                    for (int j = -1; j <= index-1; j++)
                    {
                        bankAcc[j+1].CurrentOwner();
                        bankAcc[j+1].CurrentBalance();

                        (bankAcc[j+1] as Deposite)?.SettingPercent(percent);
                        (bankAcc[j+1] as Deposite)?.InterestAccrual();

                        (bankAcc[j+1] as CardAcc)?.SettingPercent(percent);
                        (bankAcc[j+1] as CardAcc)?.InterestAccrual();
                    }
                }

                Console.WriteLine("Continue (Y) or Exit (N)");
                string check = Console.ReadLine();
                if (check == "N")
                {
                    exitWorkWithAcc = false;
                }
            } while (exitWorkWithAcc == true);
            }
        }
    }

