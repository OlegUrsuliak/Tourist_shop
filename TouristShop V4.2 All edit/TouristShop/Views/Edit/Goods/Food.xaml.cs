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
    public partial class Food : Page
    {
        Controllers.Goods.Food cFood;
        public int s;
        public Food(int idForSeacher)
        {
            s = idForSeacher;
            InitializeComponent();
            cFood = new Controllers.Goods.Food();
            ShowOneInfo();
        }
        private void ShowOneInfo()
        {
            foreach (var food in cFood.GetOneFood(s))
            {
                txbDescription.Text = food.description.ToString();
                txbDistributorId.Text = food.distributor_id.ToString();
                txbMass.Text = food.mass.ToString();
                txbName.Text = food.name.ToString();
                txbNumber.Text = food.number.ToString();
                txbPrice.Text = food.price.ToString();
                txbTeg.Text = food.teg.ToString();
            }
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (cFood.EditFood(s,
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
            txbTeg.Clear();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.Goods.Food());
        }
    }
}
