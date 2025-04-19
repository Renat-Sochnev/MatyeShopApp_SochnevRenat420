using MatyeShopApp_SochnevRenat420.MyPages;
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

namespace MatyeShopApp_SochnevRenat420
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationFrame.Navigate(new ServiceListPage());
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Вы точно хотите закрыть приложение?", "Вопрос", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Close();
            }
        }
    }
}
