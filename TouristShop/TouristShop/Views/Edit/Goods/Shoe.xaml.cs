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
    public partial class Shoe : Page
    {
        Controllers.Goods.Shoe cShoe;
        public int s;
        public Shoe(int idForSeacher)
        {
            s = idForSeacher;
            InitializeComponent();
            cShoe = new Controllers.Goods.Shoe();

            ShowOneInfo();
        }

        private void ShowOneInfo()
        {
            foreach (var shoe in cShoe.GetOneShoes(s))
            {
                txbDescription.Text = shoe.description.ToString();
                txbDistributorId.Text = shoe.distributor_id.ToString();
                txbName.Text = shoe.name.ToString();
                txbNumber.Text = shoe.number.ToString();
                txbPrice.Text = shoe.price.ToString();
                txbSex.Text = shoe.sex.ToString();
                txbSize.Text = shoe.size.ToString();
                txbTeg.Text = shoe.teg.ToString();
            }
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (cShoe.EditShoe(s,
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
