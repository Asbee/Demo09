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

namespace T1
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
        int i = 0;
        private void button_Click(object sender, RoutedEventArgs e)
        {
           
            i++;
            Trucks.Text = i.ToString();
           
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        int a = 0;
        private void cars_Click(object sender, RoutedEventArgs e)
        {
            a++;
            Cars.Text = a.ToString();
        }
    }
}
