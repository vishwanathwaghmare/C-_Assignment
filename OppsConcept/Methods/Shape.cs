using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Methods
{
    abstract public class Shape
    {
        public Shape() { 
        }
        public abstract string Draw(string name);
        public abstract void Area();
        public string Display()
        {
            return "this is shape class";
        }
    }

    public class Circle : Shape
    {
        private const double pi = 3.14;
        private int r;
        private double area;

        public Circle(int r)
        {
            this.r = r;

        }
        public override void Area()
        {
            area = pi * r * r;
        }
        public override string Draw(string name)
        {
            return name;
        }

        
        public string Print()
        {
            return $"area of circle is{area}";
        }
    }

    public class Rectangle : Shape
    {
        private double l;
        private double w;
        private double area;

        public Rectangle(double l, double w)
        {
            this.l = l;
            this.w = w;

        }
        public override void Area()
        {
             area= l * w;
        }
        public override string Draw(string name)
        {
            return name;
        }
        public string Print()
        {
            return$"Area of Rectangle is:{area}";
        }
    }

    public class Square : Shape
    {
        private double side;
        private double area;

        public Square(double side)
        {
            this.side = side;
        }
        public override void Area()
        {
            area=side * side;
        }

        public override string Draw(string name)
        {
            return name;
        }

        public string Print()
        {
            return $"aria of Square is:{area}";
        }
    }

    public class Triangle : Shape
    {
        private double l;
        private double h;
        private double area;

        public Triangle(double l,double h)
        {
            this.l=l;
            this.h=h;
                
        }
        public override void Area()
        {
            area= 0.5 * l * h;
        }
        public override string Draw(string name)
        {
            return name;
        }
        public string Print()
        {
            return $"aria of Triangle is:{area}";
        }

    }
    
}
