﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_4
{
    class SavingsAccount : BankAccount
    {
        private double rate;

        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public SavingsAccount() { }


        public double CalculateInterest()
        {
            return Balance * (1.0 + (Rate/100));
        }

        public string ToString()
        {
            return base.ToString();
        }

        public SavingsAccount(string no, string name, double b, double r) : base(no, name, b)
        {
            Rate = r;
        }

    }
}
