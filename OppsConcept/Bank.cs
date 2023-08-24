using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept
{
    internal class Bank
    {
        private int accno;
        private string name;
        private double accbalance;

        public Bank(int accno, string name, double accbalance)
        {
            this.accno = accno;
            this.name = name;
            this.accbalance = accbalance;
        }

        public void Credit(double creditamt)
        {
            accbalance+=creditamt;
        }

        public string Debit(double debitamt)
        {
            string msg = "";

            if(debitamt<=accbalance)
            {
                accbalance = accbalance - debitamt;
                msg = "Done transaction";
            }
            else
            {
                msg = "Insufficientb balance";
            }
            return msg;
        }
        public string Print()
        {
            return $"Acc no{accno}\n Name={name}\n Balance={accbalance}";
        }

    }
}
