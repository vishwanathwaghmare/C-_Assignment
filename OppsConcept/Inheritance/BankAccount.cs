using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Inheritance
{
    // multilevel inheritance
    class BankAccount
    {
        protected double balance;

        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C}. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }
    class SavingsAccount : BankAccount
    {
        public SavingsAccount(double initialBalance) : base(initialBalance) { }

        public void CalculateInterest()
        {
            double interest = balance * 0.03; // 3% annual interest
            balance += interest;
            Console.WriteLine($"Interest added: {interest:C}. New balance: {balance:C}");
        }
    }

}
