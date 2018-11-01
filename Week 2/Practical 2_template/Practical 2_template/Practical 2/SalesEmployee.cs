using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_2
{
    class SalesEmployee
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string name;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double basicSalary, sales;

        public double BasicSalary
        {
            get { return basicSalary; }
            set { basicSalary = value; }
        }

        public double Sales
        {
            get { return sales; }
            set { sales = value; }
        }


        public SalesEmployee(int d, string n, double bSalary, double s)
        {
            ID = d;
            Name = n;
            BasicSalary = bSalary;
            Sales = s;
        }

        public SalesEmployee()
        {
            ID = 0;
            Name = "Invalid";
            BasicSalary = 0.00;
            Sales = 0.00;
        }
    }
}
