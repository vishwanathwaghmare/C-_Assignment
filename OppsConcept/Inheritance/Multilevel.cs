using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Inheritance
{
    internal class Multilevel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---BankAccount");
            SavingsAccount savingsAccount = new SavingsAccount(1000);

            savingsAccount.Deposit(500);
            savingsAccount.CalculateInterest();
            savingsAccount.Withdraw(200);

            Console.WriteLine("----Shape1");
            ColoredCircle coloredCircle = new ColoredCircle("red");

            coloredCircle.DisplayInfo();
            coloredCircle.DisplayColor();
        }
    }
}
