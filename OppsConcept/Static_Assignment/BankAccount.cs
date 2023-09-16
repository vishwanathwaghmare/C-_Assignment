using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Static_Assignment
{
    using System;

    class BankAccount
    {
        // Fields
        private decimal balance;
        private string accountHolder;
        private string accountNumber;

        // Constructor
        public BankAccount(string accountHolder, string accountNumber, decimal initialBalance)
        {
            this.accountHolder = accountHolder;
            this.accountNumber = accountNumber;
            balance = initialBalance;
        }

        // Method to add money (visible to family members)
        public void AddMoney(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"{accountHolder}'s account balance updated. New balance: {balance:C}");
        }

        // Method to check account balance (visible to family members)
        public decimal CheckBalance()
        {
            Console.WriteLine($"{accountHolder}'s account balance: {balance:C}");
            return balance;
        }

        // Method to add a secret amount of money (accessible only to the President)
        protected void AddSecretMoney(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"[Secret] {accountHolder}'s account balance updated secretly. New balance: {balance:C}");
        }
    }

    class PresidentAccount : BankAccount
    {
        public PresidentAccount(string accountHolder, string accountNumber, decimal initialBalance)
            : base(accountHolder, accountNumber, initialBalance)
        {
        }

        // Method to add a secret amount of money (only accessible to the President)
        public void AddSecretFunds(decimal amount)
        {
            base.AddSecretMoney(amount);
        }
    }

    class FamilyMember
    {
        public void AccessAccount(BankAccount account)
        {
            account.AddMoney(1000); // Family members can add money
            account.CheckBalance(); // Family members can check the balance
                                    // The following line will result in a compilation error because AddSecretMoney is protected and not accessible to family members.
                                    // account.AddSecretMoney(5000);
        }
    }

    class Bankacc
    {
        static void Main(string[] args)
        {
            PresidentAccount presidentAccount = new PresidentAccount("President", "123456", 1000000);
            FamilyMember familyMember = new FamilyMember();

            familyMember.AccessAccount(presidentAccount); // Family member can access and add money to the account

            presidentAccount.AddSecretFunds(10000); // President can add secret funds
            presidentAccount.CheckBalance(); // President can check the balance

            
        }
    }

}
