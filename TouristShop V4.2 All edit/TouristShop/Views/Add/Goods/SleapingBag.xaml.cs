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

    public partial class SleapingBag : Page
    {
        Controllers.Goods.SleapingBag cSleapingBag;
        public SleapingBag()
        {
            InitializeComponent();
            cSleapingBag = new Controllers.Goods.SleapingBag();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (cSleapingBag.AddSleapingBag(
                txbName.Text,
                Int32.Parse(txbPrice.Text),
                Int32.Parse(txbNumber.Text),
                txbSeason.Text,
                Int32.Parse(txbComfortableTemperature.Text),
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
            txbComfortableTemperature.Clear();
            txbDescription.Clear();
            txbDistributorId.Clear();
            txbName.Clear();
            txbNumber.Clear();
            txbPrice.Clear();
            txbSeason.Clear();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.Goods.SleapingBag());
        }
    }
}
