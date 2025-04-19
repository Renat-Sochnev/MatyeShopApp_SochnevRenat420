using MatyeShopApp_SochnevRenat420.DB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MatyeShopApp_SochnevRenat420
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MatyeShopDBEntities db = new MatyeShopDBEntities();
    }
}
