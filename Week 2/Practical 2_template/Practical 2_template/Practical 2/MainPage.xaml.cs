using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Practical_2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();

            //Question 2
            //Create 5 Student objects

            //Creating Student object 1
            DateTime dob = new DateTime(2000, 10, 13);
            Student s1 = new Student(1, "John Tan", "88552211", dob);

            //Creating Student object 2
            DateTime dob2 = new DateTime(2001, 01, 20);
            Student s2 = new Student(2, "Emmanuel", "98597723", dob);

            //Creating Student object 3
            DateTime dob3 = new DateTime(1999, 10, 28);
            Student s3 = new Student(3, "Cake", "98765432", dob);

            //Creating Student object 4
            DateTime dob4 = new DateTime(2001, 04, 21);
            Student s4 = new Student(4, "Kitkat", "81763543", dob);

            //Creating Student object 5
            DateTime dob5 = new DateTime(2001, 05, 08);
            Student s5 = new Student(5, "Candy Floss", "87865345", dob);

            List<Student> studentList = new List<Student>();

            studentList.Add(s1);
            studentList.Add(s2);
            studentList.Add(s3);
            studentList.Add(s4);
            studentList.Add(s5);

            List<String> classmate = new List<String>();

            foreach (Student s in studentList)
            {
                classmate.Add(s.Name + ", " + s.Phone);
            }

            classmateListView.ItemsSource = classmate;

            s1Text.Text = string.Format("Id={0}, Name={1}", s1.ID.ToString(), s1.Name);
            s2Text.Text = string.Format("Id={0}, Name={1}", s2.ID.ToString(), s2.Name);
            s3Text.Text = string.Format("Id={0}, Name={1}", s3.ID.ToString(), s3.Name);
            s4Text.Text = string.Format("Id={0}, Name={1}", s4.ID.ToString(), s4.Name);
            s5Text.Text = string.Format("Id={0}, Name={1}", s5.ID.ToString(), s5.Name);

            SalesEmployee se1 = new SalesEmployee(101, "Angie", 1200, 15000);
            SalesEmployee se2 = new SalesEmployee(105, "Cindy", 1200, 15000);
            SalesEmployee se3 = new SalesEmployee(108, "David", 1200, 15000);
            SalesEmployee se4 = new SalesEmployee(112, "Jason", 1200, 15000);
            SalesEmployee se5 = new SalesEmployee(127, "Vivian", 1200, 15000);

            List<SalesEmployee> employeeList = new List<SalesEmployee> {se1, se2, se3, se4, se5};


            List<string> employeeview = new List<string>();

            foreach (SalesEmployee i in employeeList)
            {
                employeeview.Add(i.ID.ToString() + ", "+ i.Name + ", " + i.BasicSalary.ToString() + ", " + i.Sales.ToString());
            }
            SalesEmployeeListView.ItemsSource = employeeview;
        }

    }
}
