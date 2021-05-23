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

namespace HeavyTransportation
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ClassFrames.FrmMainWindow = Frm_MainWindow;
            ClassFrames.BtnBack = Btn_Back;
            Btn_Back.Visibility = Visibility.Hidden;
            ClassFrames.FrmMainWindow.Navigate(new Pages.FirstPage());
            ClassDataBase.DBheavyTransportation = new DataBase.HeavyTransportationEntities();
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {

            if (ClassFrames.FrmMainWindow.CanGoBack == true)

            {
                ClassFrames.FrmMainWindow.GoBack();
                if (!ClassFrames.FrmMainWindow.CanGoBack)
                {
                    Btn_Back.Visibility = Visibility.Hidden;
                }

            }
        }
    }
}
