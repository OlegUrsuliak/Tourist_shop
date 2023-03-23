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

namespace TouristShop.Views.Add.Goods
{
    public partial class Dish : Page
    {
        Controllers.Goods.Dish cDish;
        public Dish()
        {
            InitializeComponent();
            cDish = new Controllers.Goods.Dish();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (cDish.AddDish(
                txbName.Text,
                Int32.Parse(txbPrice.Text),
                Int32.Parse(txbMass.Text),
                Int32.Parse(txbNumber.Text),
                txbTeg.Text,
                txbDescription.Text,
                Int32.Parse(txbDistributorId.Text)
                ))
            {
                ClearTxb();
            }
            else
                MessageBox.Show("Error");
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearTxb();
        }
        private void ClearTxb()
        {
            txbDescription.Clear();
            txbDistributorId.Clear();
            txbMass.Clear();
            txbName.Clear();
            txbNumber.Clear();
            txbPrice.Clear();
            txbTeg.Clear();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.Goods.Dish());
        }
    }
}
