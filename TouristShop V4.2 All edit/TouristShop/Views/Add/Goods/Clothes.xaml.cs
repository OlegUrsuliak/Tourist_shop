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
    public partial class Clothes : Page
    {
        Controllers.Goods.Clothes cClothes;
        public Clothes()
        {
            InitializeComponent();
            cClothes = new Controllers.Goods.Clothes();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (cClothes.AddClothes(
                txbName.Text,
                txbSex.Text,
                txbSize.Text,
                txbTeg.Text,
                Int32.Parse(txbPrice.Text),
                Int32.Parse(txbNumber.Text),
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
            NavigationService.Navigate(new Views.Show.Goods.Clothes());
        }
    }
}
