using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_6
{
    abstract class Shape
    {
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public abstract double FindArea();

        public abstract double FindPerimeter();

        public Shape() { }

        public Shape(string t, string c)
        {
            Type = t;
            Color = c;
        }

        public override string ToString()
        {
            return Type + "\t\t" + Color;
        }

    }
}
