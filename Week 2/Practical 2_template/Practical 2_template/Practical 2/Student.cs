using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_2
{
    class Student
    {
        //Question 1
        //Complete the missing attributes & Properties
        
        private string phone, name;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private DateTime dateofBirth;

        public DateTime DateofBirth
        {
            get { return dateofBirth; }
            set { dateofBirth = value; }
        }

        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public Student(int i, string n, string hp, DateTime dob)
        {
            ID = i;
            Name = n;
            Phone = hp;
            DateofBirth = dob;
        }

        private DateTime dob = new DateTime(2018, 01, 01);

        public Student()
        {
            ID = 0;
            Name = "Invalid";
            Phone = "Invalid";
            DateofBirth = dob; 
        }

    }
}

