using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_4
{
    class BankAccount
    {
        private string accNo, accName;
        private double balance;

        public string AccNo
        {
            get { return accNo; }
            set { accNo = value; }
        }

        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(double d)
        {

        }
        
        public bool Withdraw(double w)
        {
            return true;
        }

        public double EquireBalance()
        {
            return 20.0;
        }

        public string ToString()
        {
            return AccNo + ", " + AccName + ", " + Balance;
        }

        protected BankAccount() { }
        protected BankAccount(string no, string name, double b)
        {
            AccNo = no;
            AccName = name;
            Balance = b;
        }

    }
}
