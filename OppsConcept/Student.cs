using OppsConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace OppsConcept
{
    public class Student 
    {
        private int id;
        private string sname;

        private double java, python, networking,percentage;
        private char grade;

        public void AcceptDetails(int id, string sname,double java,double python, double networking, double percentage,char grade)
        {
            this.id =id;
            this.sname = sname;
            this.java = java;
            this.python=python;
            this.networking =networking;
            this.percentage =percentage;
            this.grade = grade;


        }

        public void calculatePercentage()
        {
            double total = java + python + networking;
            percentage = total / 3;
        }

        public void AssignGrade()
        {
            if (percentage >= 90)
            {
                grade = 'O';

            }
            else if (percentage >= 70)
            {
                grade = 'A';
            }
            else if (percentage >= 50)
            {
                grade = 'B';
            }
            else if (percentage >= 40)
            {
                grade = 'c';
            }
            else
            {
                grade = 'F';
            }

        }
        public string DisplayMarks()
        {
            return $"student  roll no is={id}, Name={sname},Subject 1={java},Subject 2={python},Subject 3={networking},Percentage={percentage}";
        }

    }






  

}


public class program2
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.AcceptDetails(1,"vishwanath",80,70,60,300,'A');
        Console.WriteLine(student.DisplayMarks());
        

    }
}
