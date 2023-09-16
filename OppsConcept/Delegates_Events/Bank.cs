using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Delegate_Events
{
    public class Bank
    {
        private double balance;
        public event EventHandler<string> insufficientBalance;
        public event EventHandler<string> LowBalance;
        public event EventHandler<string> ZeoBalance;

        public Bank(double initialBalance)
        {
            balance = initialBalance;
        }
        public void Credit(double amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Amount should be greater than zero");
                    balance += amount;

                    if (balance < 3000)
                    {

                    }
                }
            } 
            catch (Exception ex)
            {

            }

        }

    }
    
}
