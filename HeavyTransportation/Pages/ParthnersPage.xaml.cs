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
    /// Логика взаимодействия для ParthnersPage.xaml
    /// </summary>
    public partial class ParthnersPage : Page
    {
        public ParthnersPage()
        {
            InitializeComponent();
        }

        private void Rdb_WithParthner_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_ShowTable_Click(object sender, RoutedEventArgs e)
        {
            if (Rdb_WithParthner.IsChecked == true)

            {

                ClassFrames.FrmMainWindow.Navigate(new RouteDriversPage());

            }

            else
            {

                if (Rdb_WithoutParthner.IsChecked == true)

                {

                    ClassFrames.FrmMainWindow.Navigate(new RouteDriversWithoutParthnerPage());

                }

            }

        }
    }
}
