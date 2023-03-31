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
    public partial class Literature : Page
    {
        Controllers.Goods.Literature cLiterature;
        public int s;
        public Literature(int idForSeacher)
        {
            s = idForSeacher; //Передача ід для визначення потрібного id
            InitializeComponent();
            cLiterature = new Controllers.Goods.Literature();
            ShowOneInfo();
        }
        private void ShowOneInfo()
        {
            foreach (var literature in cLiterature.GetOneLiterature(s))
            {
                txbDescription.Text = literature.description.ToString();
                txbDistributorId.Text = literature.distributor_id.ToString();
                txbName.Text = literature.name.ToString();
                txbNumber.Text = literature.number.ToString();
                txbPrice.Text = literature.price.ToString();
                txbTeg.Text = literature.teg.ToString();
            }
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (cLiterature.EditLiterature(s,
                txbName.Text,
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
            txbTeg.Clear();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.Goods.Literature());
        }
    }
}
