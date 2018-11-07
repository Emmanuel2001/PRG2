using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp
{
    class Cylinder : Circle
    {
        private double length;
        
        public double Length
        {
            get { return length; }
            set { length = value; }

        }

        public override double CalculateArea()
        {
            double sarea = 2 * Math.PI * Radius * Length + 2 * Math.PI * Math.Pow(Radius, 2);
            return sarea;
        }
        public double CalculateVolume()
        {
            return CalculateArea() * Length;
        }

        public string ToString()
        {
            return "volume" + CalculateVolume();
        }
        public Cylinder() { }

        public Cylinder(double r, double l)
        {
            Radius = r;
            Length = l;
        }
    }
}
