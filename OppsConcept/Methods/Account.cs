using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OppsConcept.Methods
{
    //create class Account containing the following methods => insert(),display(),deposit(),withdraw(),checkBalance().
    public class Account
    {
        public int acc_no { get; set; }
        public string Name { get;set; }
        public string acc_type { get;set; }
        public float amount { get;set; }

        public Account(int acc_no, string Name, string acc_type, float amount)
        {
            this.acc_no = acc_no;
            this.Name = Name;
            this.acc_type = acc_type;
            this.amount = amount;

        }

        public void insert(int acc_no, string Name, string acc_type,float amount)
        {
            this.acc_no = acc_no;
            this.Name= Name;
            this.acc_type = acc_type;
            this.amount = amount;
        }
        public void Display()
        {
            Console.WriteLine("Account Number:"+acc_no);
            Console.WriteLine("Name of Acc Holder:"+Name);
            Console.WriteLine("Account type:"+acc_type);
            Console.WriteLine("Current Balance:"+amount);
        }
        public void Deposit(float depAmount)
        {
            if (depAmount > 0)
            {
                amount = amount+depAmount;
                Console.WriteLine("Amount Deposited Successfully......");
            }
        }
        public void Withdraw(float withAmount)
        {
            if(withAmount>0&& withAmount < amount)
            {
                amount = amount-withAmount;
                Console.WriteLine("Amount Withdrawn successfully.....");
            }
            else
            {
                Console.WriteLine("Balance insufficient to withdraw");
            }
        }
        public void CheckBalance()
        {
            Console.WriteLine("Account Balance is:"+amount);
        }

    }




    class AccMethod
    {
        static void Main(string[] args)
        {
            Account account=new Account(101,"Vishwanath","Saving",10000.0f);

            account.Display();
            account.Deposit(5000);
            account.CheckBalance();
            account.Withdraw(3000);
            account.CheckBalance();

        }
    }
}
