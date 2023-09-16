using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Overriding
{
    public class Bank
    {
        public void DisplayInterestRate(string accountType)
        {
            double interestRate;

            switch (accountType.ToLower())
            {
                case "default":
                    interestRate = 2.0;
                    break;
                case "savings":
                    interestRate = 3.0;
                    break;
                case "current":
                    interestRate = 5.0;
                    break;
                default:
                    Console.WriteLine("Invalid account type.");
                    return;
            }

            Console.WriteLine($"The interest rate for {accountType} account is {interestRate}%.");
        }
    }


    class Bank1
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            Console.Write("Enter the account type (default/savings/current): ");
            string accountType = Console.ReadLine();

            bank.DisplayInterestRate(accountType);
        }
    }

}
