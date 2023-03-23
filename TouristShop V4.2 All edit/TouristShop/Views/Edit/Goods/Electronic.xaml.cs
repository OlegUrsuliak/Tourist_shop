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
    public partial class Electronic : Page
    {
        Controllers.Goods.Electronic cElectronic;
        public int s;
        public Electronic(int idForSearch)
        {
            s = idForSearch;
            InitializeComponent();
            cElectronic = new Controllers.Goods.Electronic();
            
            ShowOneInfo();
        }
        private void ShowOneInfo()
        {
            foreach (var electronic in cElectronic.GetOneElectronics(s))
            {
                txbDescription.Text = electronic.description.ToString();
                txbDistributorId.Text = electronic.distributor_id.ToString();
                txbMass.Text = electronic.mass.ToString();
                txbName.Text = electronic.name.ToString();
                txbNumber.Text = electronic.number.ToString();
                txbPrice.Text = electronic.price.ToString();
                txbTeg.Text = electronic.teg.ToString();
            }

        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (cElectronic.EditBackpack(s,
                txbName.Text,
                 Int32.Parse(txbNumber.Text),
                 Int32.Parse(txbMass.Text),
                 Int32.Parse(txbPrice.Text),
                 txbTeg.Text,
                 txbDescription.Text,
                 Int32.Parse(txbDistributorId.Text)
                ))
            {
                ClearTxb();
            }
            else
                MessageBox.Show("Error with adding");
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
            NavigationService.Navigate(new Views.Show.Goods.Electronic());
        }
    }
}
