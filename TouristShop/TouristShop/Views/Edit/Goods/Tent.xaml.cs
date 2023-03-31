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
    public partial class Tent : Page
    {
        Controllers.Goods.Tent cTent;
        public int s;
        public Tent(int idForSeacher)
        {
            s = idForSeacher;
            InitializeComponent();

            cTent = new Controllers.Goods.Tent();
            ShowOneInfo();
        }

        private void ShowOneInfo()
        {
            foreach (var tent in cTent.GetOneTent(s))
            {
                txbDescription.Text = tent.name.ToString();
                txbDistributorId.Text = tent.distributor_id.ToString();
                txbMass.Text = tent.mass.ToString();
                txbName.Text = tent.name.ToString();
                txbNumber.Text = tent.number.ToString();
                txbPrice.Text = tent.price.ToString();
                txbSize.Text = tent.size.ToString();
            }
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (cTent.EditTent(s,
                txbName.Text,
                Int32.Parse(txbSize.Text),
                Int32.Parse(txbNumber.Text),
                Int32.Parse(txbMass.Text),
                Int32.Parse(txbPrice.Text),
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
            txbDescription.Clear();
            txbDistributorId.Clear();
            txbMass.Clear();
            txbName.Clear();
            txbNumber.Clear();
            txbPrice.Clear();
            txbSize.Clear();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.Goods.Tent());
        }
    }
}
