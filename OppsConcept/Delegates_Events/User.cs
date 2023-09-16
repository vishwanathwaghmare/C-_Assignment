using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Delegate_Events
{
    public class User
    {
        public string AcceptName(string name)
        {
            return name.ToUpper();  
        }
        public string AcceptsName(string name)
        {
            return name.ToLower();
        }
    }
    delegate string NameDelegate(string name);


    public class DelegatesEx
    {
        static void Main(string[] args)
        {
            User user = new User();

            NameDelegate n =new NameDelegate (user.AcceptName);
            NameDelegate n1 = new (user.AcceptsName);
            Delegate[]list =n.GetInvocationList();
            

            string Name = "vishwanath WAGHMARE";
            string modifiedName=n.Invoke(Name);
            string modifiedName1=n1.Invoke(Name);

            //Console.WriteLine("Original Name: "+Name);

            Console.WriteLine("Modified Name in Upper Case: "+modifiedName);
            Console.WriteLine("Modified Name in Lower Case:" +modifiedName1);

        }
    }
}
