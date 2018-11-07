using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp
{
    class Circle
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public virtual double CalculateArea()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
        
        public string ToString()
        {
            return "Area:" + CalculateArea();
        }

        public Circle() { }

        public Circle(double r)
        {
            Radius = r;
        }
    }
}
