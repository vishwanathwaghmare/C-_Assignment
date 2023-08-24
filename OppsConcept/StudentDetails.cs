using OppsConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept
{
    public class StudentDetails
    {
        private int rollno;
        private string name;
        private double  s1, s2, s3, total;

        public void StudInfo(int rollno,string name,double s1,double s2,double s3)
        {
            this.rollno = rollno;
            this.name = name;
         
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;


        }
        public void CalcPercentage()
        {
            total = s1 + s2 + s3/3 ;
            

        }

        public string PrintInfo()
        {
            return $"Roll No={rollno},Name={name},{total}";

        }

        
    }
}



