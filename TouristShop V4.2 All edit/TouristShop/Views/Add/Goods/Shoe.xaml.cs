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
    public partial class Shoe : Page
    {
        Controllers.Goods.Shoe cShoe;
        public Shoe()
        {
            InitializeComponent();
            cShoe = new Controllers.Goods.Shoe();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (cShoe.AddShoes(
                txbName.Text,
                txbSex.Text,
                Int32.Parse(txbSize.Text),
                Int32.Parse(txbPrice.Text),
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
            txbName.Clear();
            txbNumber.Clear();
            txbPrice.Clear();
            txbSex.Clear();
            txbSize.Clear();
            txbTeg.Clear();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.Goods.Shoe());
        }
    }
}
