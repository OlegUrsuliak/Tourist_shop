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

namespace TouristShop.Views.Edit.Goods
{
    public partial class SleapingBag : Page
    {
        Controllers.Goods.SleapingBag cSleapingBag;
        private int s;
        public SleapingBag(int idForSeacher)
        {
            s = idForSeacher;
            InitializeComponent();
            cSleapingBag = new Controllers.Goods.SleapingBag();

            ShowOneInfo();
        }

        private void ShowOneInfo()
        {
            foreach (var sleapingBag in cSleapingBag.GetOneSleapingBag(s))
            {
                txbComfortableTemperature.Text = sleapingBag.comfortableTemperature.ToString();
                txbDescription.Text = sleapingBag.description.ToString();
                txbDistributorId.Text = sleapingBag.distributor_id.ToString();
                txbName.Text = sleapingBag.name.ToString();
                txbNumber.Text = sleapingBag.number.ToString();
                txbPrice.Text = sleapingBag.price.ToString();
                txbSeason.Text = sleapingBag.season.ToString();
            }
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (cSleapingBag.EditSleapingBag(s,
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
                MessageBox.Show("Error with edit");
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
