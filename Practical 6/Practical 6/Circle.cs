using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_6
{
    class Circle : Shape, IComparable<Circle>
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public override double FindArea()
        {
            return Math.Round((Math.PI * Math.Pow(Radius, 2)), 2);
        }

        public override double FindPerimeter()
        {
            return Math.Round((2 * Math.PI * Radius), 2);
        }

        public Circle() { }

        public Circle(string c, double r) : base("Circle", c)
        {
            Radius = r;
        }

        public override string ToString()
        {
            return base.ToString() +"\t\t" + Radius + '\n';
        }

        public int CompareTo(Circle x)
        {
            if (Radius > x.Radius)
            
                return 1;
            
            else if (Radius == x.Radius)
            
                return 0;
            
            else
            
                return -1;
            
        }
    }
}
