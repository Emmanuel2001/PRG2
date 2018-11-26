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

namespace Practical_6
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<Circle> shapeList = new List<Circle>();

        public void InitShapeList()
        {
            Circle c1 = new Circle("Red", 20.0);
            Circle c2 = new Circle("Green", 10.0);
            Circle c3 = new Circle("Blue", 30.0);
            shapeList.Add(c1);
            shapeList.Add(c2);
            shapeList.Add(c3);


        }
        public MainPage()
        {
            this.InitializeComponent();
            InitShapeList();

            
        }

        

        private void listAllBtn_Click(object sender, RoutedEventArgs e)
        {
            detailsTxt.Text = "Type\t\tColor\t\tRadius\t\t\n";
            if (shapeList.Count != 0)
            {
                foreach (Circle c in shapeList)
                {
                    detailsTxt.Text += c.ToString();
                }
            }
            else
            {
                detailsTxt.Text += "The List is empty.";
            }
            
        }

        private void displayAreaBtn_Click(object sender, RoutedEventArgs e)
        {
            detailsTxt.Text = "No\t\tType\t\tArea\n";
            int i = 1;
            foreach (Circle c in shapeList)
            {
                detailsTxt.Text += Convert.ToString(i) + "\t\t" + c.Type + "\t\t" + c.FindArea() + '\n';
                i++;
            }
        }

        private void displayPerimeterBtn_Click(object sender, RoutedEventArgs e)
        {
            detailsTxt.Text = "No\t\tType\t\tPerimeter\n";
            int i = 1;
            foreach (Circle c in shapeList)
            {
                detailsTxt.Text += Convert.ToString(i) + "\t\t" + c.Type + "\t\t" + c.FindPerimeter() + '\n';
                i++;
            }
        }

        private void addCircleBtn_Click(object sender, RoutedEventArgs e)
        {
            Circle c4 = new Circle("Red", 10);
            shapeList.Add(c4);
            detailsTxt.Text = "Type\t\tColour\t\tRadius\n";
            foreach (Circle c in shapeList)
            {
                detailsTxt.Text += c.Type + "\t\t" + c.ToString();
            }
            detailsTxt.Text += "A new circle is added to list.";
        }

        private void deleteCircleBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                shapeList.Remove(shapeList[shapeList.Count - 1]);
                detailsTxt.Text = "Type\t\tColour\t\tRadius\n";
                foreach (Circle c in shapeList)
                {
                    detailsTxt.Text += c.Type + "\t\t" + c.ToString();
                }
                detailsTxt.Text += "The last circle object is deleted to list.";
            }
            catch (Exception)
            {
                detailsTxt.Text = "An Error has occured, there is no circle to delete.";
            };

            
        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {

            shapeList.Sort();
            detailsTxt.Text = "Type\t\tColour\t\tRadius\n";
            foreach (Circle c in shapeList)
            {
                detailsTxt.Text += c.ToString();
            }
            detailsTxt.Text += "The List has been sorted by Radius.";


        }
    }
}
