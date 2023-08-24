using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Methods
{
    public class Student2
    {
        private int id;
        private string name;

        public Student2(int StudId,string StudName)
        {
            id=StudId;
            name=StudName;
        }

        private int GetId()
        {
            return 100;
        }
        public void SetCustomData(int customId,string customName)
        {
            id = customId; 
            name=customName; 
        }
        public void displayData()
        {
            int newId = GetId();
            id=newId;
            //id = 1;
            name = "vishwanath";
            Console.WriteLine("changed id="+id);
            Console.WriteLine("changed name="+name);
        }
    }


    public class S2
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter id before change");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter name before change");
            string n = Convert.ToString(Console.ReadLine());

            Student2 s = new Student2(i, n);



            s.displayData();
            s.SetCustomData(101,"Ajay");
        }
    }
}
