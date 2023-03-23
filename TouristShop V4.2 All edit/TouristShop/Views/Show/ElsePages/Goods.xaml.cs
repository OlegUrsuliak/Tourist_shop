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
    public partial class Goods : Page
    {
        public Goods()
        {
            InitializeComponent();
        }
        private void btnTent_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.Goods.Tent());
        }
        private void btnBackpack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.Goods.Backpack());
        }
        private void btnClothes_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.Goods.Clothes());
        }
        private void btnShoes_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.Goods.Shoe());
        }
        private void btnSleapingBags_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.Goods.SleapingBag());
        }
        private void btnCaremat_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.Goods.Caremat());
        }
        private void btnDishes_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.Goods.Dish());
        }
        private void btnLiterature_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.Goods.Literature());
        }
        private void btnEquipment_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.Goods.Equipment());
        }
        private void btnElectronica_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.Goods.Electronic());
        }
        private void btnFood_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.Goods.Food());
        }

        private void btnReturnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.ElsePages.MainMenu());
        }
    }
}
