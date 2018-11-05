using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac3
{
    class CashCard
    {
        private string id;
        private double val;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public double Val
        {
            get { return val; }
            set { val = value; }
        }

        public double TopUp(double c)
        {
            
            double final = val += c;

            return final;
        }

        public bool Deduct(double d)
        {
            return true;
        }

        public string toString()
        {
            return(ID+", "+Val);
        }

        public CashCard(string i, double v)
        {
            ID = i;
            Val= v;
        }
        public CashCard()
        {
            ID = "";
            Val = 0.00;
        }

    }
}

