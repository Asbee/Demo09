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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        int a = 1;
        double markka = 5.94573;
        bool success;
        double amount;

        private void Euro_Click(object sender, RoutedEventArgs e)
        {
            CurrentC.Text = "Eurosta Markaksi";
            a = 1;
        }

        private void Markka_Click(object sender, RoutedEventArgs e)
        {
            CurrentC.Text = "Markasta Euroksi";
            a = 2;
        }

        private void CurrentC_SelectionChanged(object sender, RoutedEventArgs e)
        {
           
        }

        private void Amount_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Muunnin_Click(object sender, RoutedEventArgs e)
        {
            if (a == 1)
            {
                success = double.TryParse(Amount.Text, out amount);
                amount = amount * markka;
                Amount.Text = amount.ToString("0.00");
            }
            if (a == 2)
            {
                success = double.TryParse(Amount.Text, out amount);
                amount = amount / markka;
                Amount.Text = amount.ToString("0.00");
            }
        }
    }
}
