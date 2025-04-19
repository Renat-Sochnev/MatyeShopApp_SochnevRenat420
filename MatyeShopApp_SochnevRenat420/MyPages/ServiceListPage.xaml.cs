using MatyeShopApp_SochnevRenat420.DB;
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

namespace MatyeShopApp_SochnevRenat420.MyPages
{
    /// <summary>
    /// Логика взаимодействия для ServiceListPage.xaml
    /// </summary>
    public partial class ServiceListPage : Page
    {
        private bool isCustomizationServicesShow;
        public ServiceListPage()
        {
            InitializeComponent();
            isCustomizationServicesShow = true;
            UpdateList();
        }

        private void UpdateList()
        {
            List<Service> services = App.db.Service.OrderBy(x => x.Name).ToList();
            if (isCustomizationServicesShow)
            {
                services = services.Where(s => s.ServiceType.Name == "Кастомизация").ToList();
            }
            else
            {
                services = services.Where(s => s.ServiceType.Name != "Кастомизация").ToList();
            }
            ServiceList.ItemsSource = services;
        }
        private void ShowCosplayServicesBtn_Click(object sender, RoutedEventArgs e)
        {
            if (isCustomizationServicesShow)
            {
                isCustomizationServicesShow = false;
                UpdateList();
            }
        }

        private void ShowCustomServicesBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!isCustomizationServicesShow)
            {
                isCustomizationServicesShow = true;
                UpdateList();
            }
        }
    }
}
