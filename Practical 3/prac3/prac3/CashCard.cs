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

        public void TopUp(double c)
        {

        }

        public bool Deduct(double d)
        {
            return true;
        }

        public string ToString()
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

