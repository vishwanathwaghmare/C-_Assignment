using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept
{
    //use of base keyword in single code
    public class Vehicle
    {
        protected string brand;
        public Vehicle(string brand) 
        { 
            this.brand = brand;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand:{brand}");
        }


    }
    public  class Car2 : Vehicle
    {
        private int year;
        public Car2(string brand,int year):base(brand)
        {
            this.year = year;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Year:{year}");
        }
    }
    
}
