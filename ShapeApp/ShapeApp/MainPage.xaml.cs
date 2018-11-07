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

namespace ShapeApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<Circle> shape = new List<Circle>();
        List<Cylinder> cyl = new List<Cylinder>();
        public MainPage()
        {
            this.InitializeComponent();

            Circle circle1 = new Circle(5.0);
            Cylinder cylinder1 = new Cylinder(5.0, 10.0);

            shape.Add(circle1);
            cyl.Add(cylinder1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            shape[0].Radius = Convert.ToDouble(ChangeRadius.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DisplayAreaofC.Text = shape[0].CalculateArea().ToString();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            cyl[0].Radius = Convert.ToDouble(ChangeRadiusOfCylinder.Text);

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            cyl[0].Length = Convert.ToDouble(ChangeLengthOfCylinder.Text);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            DisplaySAofCylinder.Text = cyl[0].CalculateArea().ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            DisplayVolumeOfCylinder.Text = cyl[0].CalculateVolume().ToString();
        }
    }
}
