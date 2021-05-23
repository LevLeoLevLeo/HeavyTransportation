using HeavyTransportation.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HeavyTransportation.Pages
{
    /// <summary>
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {

            Application.Current.Shutdown();

        }

        private void Btn_Drivers_Click(object sender, RoutedEventArgs e)
        {

            ClassFrames.FrmMainWindow.Navigate(new Pages.DriversPage());
            ClassFrames.BtnBack.Visibility = Visibility.Visible;

        }

        private void Btn_Orders_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
