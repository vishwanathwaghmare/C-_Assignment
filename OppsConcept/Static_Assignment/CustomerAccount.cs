using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Static_Assignment
{
    using System;

    class CustomerAccount
    {
        private decimal balance;

        public CustomerAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C}. Remaining balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient balance for withdrawal.");
            }
        }

        public void MakeDebitCardPayment(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Debit card payment of {amount:C}. Remaining balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient balance for payment.");
            }
        }

        public void UseNetBanking(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Net banking transaction of {amount:C}. Remaining balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient balance for net banking transaction.");
            }
        }

        public decimal CheckBalance()
        {
            Console.WriteLine($"Current balance: {balance:C}");
            return balance;
        }
    }

    class CustAcc
    {
        static void Main(string[] args)
        {
            CustomerAccount customerAccount = new CustomerAccount(1000.0M);

            customerAccount.CheckBalance();
            customerAccount.Withdraw(500.0M);
            customerAccount.MakeDebitCardPayment(200.0M);
            customerAccount.UseNetBanking(300.0M);
            customerAccount.CheckBalance();
        }
    }

}
