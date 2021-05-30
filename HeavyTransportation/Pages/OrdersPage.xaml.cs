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
    /// Логика взаимодействия для OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : Page
    {
        public OrdersPage()
        {
            InitializeComponent();
        }

        private void Btn_AddOrder_Click(object sender, RoutedEventArgs e)
        {
            ClassFrames.FrmMainWindow.Navigate(new AddOrder());
        }

        private void Btn_ListOrder_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
