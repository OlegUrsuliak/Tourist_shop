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

namespace TouristShop.Views.Show.ElsePages
{
    public partial class MainMenu : Page
    {
        public MainMenu(){
            InitializeComponent();
        }

        private void btnGoods_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.ElsePages.Goods());
        }
        private void btnBuyer_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.ElsePages.Buyer());
        }
        private void btnDistributor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.ElsePages.Distributor());
        }
        private void btnTenant_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new Views.Show.ElsePages.());
        }
        private void btnSetting_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.ElsePages.Setting());
        }
        private void btnExit_Click(object sender, RoutedEventArgs e){
            Application.Current.Shutdown();
        }
    }
}
