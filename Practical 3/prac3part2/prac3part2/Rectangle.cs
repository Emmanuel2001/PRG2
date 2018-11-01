using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac3part2
{
    class Rectangle
    {
        private double width, height;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double FindArea()
        {
            double area = height * width;
            return area;
        }

        public double FindPerimeter()
        {
            double perimeter = 2 * height + 2 * width;
            return perimeter;
        }

        public string ToString()
        {
            return (height + ", \t" + width);
        }

        public Rectangle(double w, double h)
        {
            Width = w;
            Height = h;

        }

        public Rectangle()
        {
            Width = 0.00;
            Height = 0.00;
        }
    }
}
