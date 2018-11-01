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

namespace prac3part2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Rectangle rect1 = new Rectangle();
        Rectangle rect2 = new Rectangle();
        List<Rectangle> rectlist = new List<Rectangle>();
        List<string> rectview = new List<string>();
        public MainPage()
        {
            this.InitializeComponent();

            InitRectangle();

            for (int i=0; i< rectlist.Count; i++)
            {
                rectview.Add(rectlist[i].ToString());
            }

            attributetxt.Text = rectview[0] + '\n' + '\n' + rectview[1];


            areaTxt.Text = rect1.FindArea().ToString();

            perimeter2txt.Text = rect2.FindPerimeter().ToString();

        }

        public void InitRectangle()
        {
            rect1.Height = 100;
            rect1.Width = 50;
            rect2.Height = 250;
            rect2.Width = 100;
            rectlist.Add(rect1);
            rectlist.Add(rect2);
        }
    }
}
