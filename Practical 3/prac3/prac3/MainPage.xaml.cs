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

namespace prac3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // List to store CashCard objects
        List<CashCard> cardlist = new List<CashCard>();
        List<string> cashcardlist = new List<string>();

        public MainPage() 
        {
            this.InitializeComponent();
            InitCardList();

            for (int i=0; i< cardlist.Count; i++)
            {
                cashcardlist.Add(cardlist[i].ToString());
            }


            cashcardListView.ItemsSource = cashcardlist;
        }

        public void InitCardList()
        {
            CashCard c1 = new CashCard("001", 25);
            CashCard c2 = new CashCard("002", 25);
            CashCard c3 = new CashCard("003", 30);
            CashCard c4 = new CashCard("004", 30);
            CashCard c5 = new CashCard("005", 50);

            cardlist.Add(c1);
            cardlist.Add(c2);
            cardlist.Add(c3);
            cardlist.Add(c4);
            cardlist.Add(c5);
        }
    }
}
