using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Delegate_Events
{
    public delegate void MyDelegate();
    public class Student
    {
        public event MyDelegate Fail;
        public event MyDelegate Pass;
        public void AcceptPercentage(double per) 
        {
            if (per < 40)
            {
                Fail();
            }
            else
            {
                Pass();
            }
        
        }

    }
    /*public class Message
    {
        public void SuccessMessage()
        {
            Console.WriteLine("You are pass in the exam ");

        }
        public void FailureMessage()
        {
            Console.WriteLine("you are fail in exam");
        }
    }*/


    public class Events
    {
        static void Main(string[] args)
        {
            try
            {
                Student stud1 = new Student();
                // Message msg = new Message();
                // stud1.Fail += new MyDelegate(msg.FailureMessage);
                // stud1.Pass += new MyDelegate(msg.SuccessMessage);
                stud1.Fail += delegate () { Console.WriteLine("you are Fail"); };
                stud1.Pass += delegate () { Console.WriteLine("you are Pass"); };
               

                stud1.AcceptPercentage(60);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

       
    }
}
