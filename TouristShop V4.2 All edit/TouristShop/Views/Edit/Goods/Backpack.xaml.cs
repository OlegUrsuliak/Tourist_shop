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
    public partial class Backpack : Page
    {
        Controllers.Goods.Backpack cBackpack;
        public int s;
        public Backpack(int idForSeacher){
            s = idForSeacher; //Передача ід для визначення потрібного id
            InitializeComponent();
            cBackpack = new Controllers.Goods.Backpack();

            ShowOneInfo();
        }
        private void ShowOneInfo()
        {
            //Відображення 1 запису для зміни
            foreach (var backpack in cBackpack.GetOneBackpack(s))
            {
                txbName.Text = backpack.name.ToString();
                txbPrice.Text = backpack.price.ToString();
                txbNumber.Text = backpack.number.ToString();
                txbSize.Text = backpack.size.ToString();
                txbMass.Text = backpack.mass.ToString();
                txbTeg.Text = backpack.teg.ToString();
                txbDescription.Text = backpack.description.ToString();
                txbDistributorId.Text = backpack.distributor_id.ToString();
            }
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (cBackpack.EditBackpack(s,         
                txbName.Text,
                Int32.Parse(txbPrice.Text),
                Int32.Parse(txbNumber.Text),
                Int32.Parse(txbSize.Text),
                Int32.Parse(txbMass.Text),
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
            txbSize.Clear();
            txbTeg.Clear();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.Goods.Backpack());
        }
    }
}
