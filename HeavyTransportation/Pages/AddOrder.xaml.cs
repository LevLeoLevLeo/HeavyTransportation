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

namespace HeavyTransportation.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddOrder.xaml
    /// </summary>
    public partial class AddOrder : Page
    {
        public AddOrder()
        {
            InitializeComponent();
            Cmd_Driver.SelectedValuePath = "Id";
            Cmd_Driver.DisplayMemberPath = "FirstName";
            Cmd_Driver.ItemsSource = ClassDataBase.DBheavyTransportation.Driver.ToList();
            
            Cmd_Trailer.SelectedValuePath = "Id";
            Cmd_Trailer.DisplayMemberPath = "Brand";
            Cmd_Trailer.ItemsSource = ClassDataBase.DBheavyTransportation.Trailer.ToList();
        }

        private void Btn_AddOrder_Click(object sender, RoutedEventArgs e)
        {
            Order orderobj = new Order()

            {

                Name = Txb_CustomerName.Text,
                DeparturePoint = Txb_DeparturePoint.Text,
                DestinationPoint = Txb_DestinationPoint.Text,
                DistanceKM = Convert.ToInt32(Txb_DistanceKM.Text),
                WeightKG = Convert.ToInt32(Txb_Weight.Text),
                Driver = Cmd_Driver.SelectedItem as Driver,
                Trailer = Cmd_Trailer.SelectedItem as Trailer,


            };

            ClassDataBase.DBheavyTransportation.Order.Add(orderobj);
            ClassDataBase.DBheavyTransportation.SaveChanges();
            MessageBox.Show ("Заказ создан!", "Заказ", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
