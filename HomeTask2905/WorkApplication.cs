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
            bool exit;
            bool exitAcc = true;
            int i = 0;
            int index = 0;
            

            BankAcc[] bankAcc = new BankAcc[5];

            do
                {
                    for (i = 0; i < bankAcc.Length; i++)
                    {
                        exit = true;
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
                                    exit = false;
                                    break;
                                case "deposite":
                                    bankAcc[i] = new Deposite(balance, owner);
                                    exit = false;
                                    break;
                                case "current":
                                    bankAcc[i] = new Current(balance, owner);
                                    exit = false;
                                    break;
                                default:
                                    Console.WriteLine("Invalid data");
                                    break;
                            }
                        } while (exit == true);

                        Console.WriteLine("Enter Y to continue or any other key for work with the accounts");
                        string exitCreateAcc = Console.ReadLine();

                        if (exitCreateAcc == "Y" || i == 5)
                        {
                            index = i;
                            exitAcc = false;
                        }
                    }
                    
            } while (exitAcc == true);
            do
                {
                Console.WriteLine("Enter what do you mean: Withdraw bank account (withraw) " +
                    "or charge interest and withdraw bank account (charge)");
                string workWithAcc =Console.ReadLine();

                if (workWithAcc == "withraw")
                {
                    for (int j = 0; j < index; i++)
                    {
                        bankAcc[j].CurrentOwner();
                        bankAcc[j].CurrentBalance();
                    }
                }
                else if (workWithAcc == "charge")
                {
                    Console.WriteLine("Enter percent");
                    double percent = Convert.ToDouble(Console.ReadLine());

                    for (int j = 0; j < index; i++)
                    {
                        bankAcc[j].GetType().
                    }
                }
                } while (exitAcc == false);
            }
        }
    }

