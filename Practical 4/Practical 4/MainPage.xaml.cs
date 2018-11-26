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

namespace Practical_4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<string> acc1details = new List<string>();
        List<SavingsAccount> accounts = new List<SavingsAccount>();
        public MainPage()
        {
            this.InitializeComponent();

            SavingsAccount account1 = new SavingsAccount("111-001", "Bob", 2000.00, 2.0);
            SavingsAccount account2 = new SavingsAccount("111-002", "Mary", 5000.00, 2.0);


            account1Txt.Text = account1.ToString();
            account2Txt.Text = account2.ToString();

            accounts.Add(account1);
            accounts.Add(account2);
        }

        private void account1DepositBtn_Click(object sender, RoutedEventArgs e)
        {
            accounts[0].Deposit(1000);
            account1Txt.Text = accounts[0].ToString();
        }

        private void account1WithdrawBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if (accounts[0].Withdraw(1000))
            {
            }
            else
            {
                Ac1.Text = "Insufficient Balance to Withdraw";
            }
            account1Txt.Text = accounts[0].ToString();
        }

        private void account1InterestBtn_Click(object sender, RoutedEventArgs e)
        {
            
            Ac1.Text = accounts[0].CalculateInterest().ToString();
        }
        private void account2DepositBtn_Click(object sender, RoutedEventArgs e)
        {
            accounts[1].Deposit(1000);
            account2Txt.Text = accounts[1].ToString();
        }

        private void account2WithdrawBtn_Click(object sender, RoutedEventArgs e)
        {
            if (accounts[1].Withdraw(1000))
            {
            }
            else
            {
                Ac2.Text = "Insufficient Balance to Withdraw";
            }
            account2Txt.Text = accounts[1].ToString();
        }

        private void account2InterestBtn_Click(object sender, RoutedEventArgs e)
        {
            Ac2.Text = accounts[1].CalculateInterest().ToString();
        }

    }
}
