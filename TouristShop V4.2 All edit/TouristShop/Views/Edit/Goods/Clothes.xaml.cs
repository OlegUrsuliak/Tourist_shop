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
    public partial class Clothes : Page
    {
        Controllers.Goods.Clothes cClothes;
        public int s;
        public Clothes(int idForSeacher)
        {
            s = idForSeacher; //Передача ід для визначення потрібного id
            InitializeComponent();

            cClothes = new Controllers.Goods.Clothes();
            ShowOneInfo();
        }

        private void ShowOneInfo()
        {
            //Відображення 1 запису для зміни
            foreach (var clothes in cClothes.GetOneClothes(s))
            {
                txbDescription.Text = clothes.description.ToString();
                txbDistributorId.Text = clothes.distributor_id.ToString();
                txbName.Text = clothes.name.ToString();
                txbNumber.Text = clothes.number.ToString();
                txbPrice.Text = clothes.price.ToString();
                txbSex.Text = clothes.sex.ToString();
                txbSize.Text = clothes.size.ToString();
                txbTeg.Text = clothes.teg.ToString();
            }
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (cClothes.EditClothes(s,
                txbName.Text.ToString(),
                txbSex.Text.ToString(),
                txbSize.Text.ToString(),
                txbTeg.Text.ToString(),
                Int32.Parse(txbPrice.Text),
                Int32.Parse(txbNumber.Text),
                txbDescription.Text.ToString(),
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
