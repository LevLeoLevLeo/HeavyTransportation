using HeavyTransportation.Class;
using HeavyTransportation.DataBase;
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
using System.Windows.Threading;

namespace HeavyTransportation.Pages
{
    /// <summary>
    /// Логика взаимодействия для RouteDriversPage.xaml
    /// </summary>
    public partial class RouteDriversPage : Page
    {
        public RouteDriversPage()
        {
            InitializeComponent();

            ClassDataBase.DBheavyTransportation.Order.Where(x => x.IdParthner == 5);

            {
                ListRoute.ItemsSource = ClassDataBase.DBheavyTransportation.Order.ToList();

                DispatcherTimer timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Tick += UpdateData;
                timer.Start();
            }
        }
        public void UpdateData(object sender, object e)
        {
            ListRoute.ItemsSource = ClassDataBase.DBheavyTransportation.Order.ToList();
        }

    }
}
