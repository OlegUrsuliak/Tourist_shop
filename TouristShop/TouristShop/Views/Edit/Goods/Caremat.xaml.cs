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
    public partial class Caremat : Page
    {
        Controllers.Goods.Caremat cCaremat;
        public int s;
        public Caremat(int idForSeacher)
        {
            s = idForSeacher; //Передача ід для визначення потрібного id
            InitializeComponent();

            cCaremat = new Controllers.Goods.Caremat();
            ShowOneInfo();
        }

        private void ShowOneInfo()
        {
            //Відображення 1 запису для зміни
            foreach (var caremat in cCaremat.GetOneCaremat(s))
            {
                txbName.Text = caremat.name.ToString();
                txbPrice.Text = caremat.price.ToString();
                txbMass.Text = caremat.mass.ToString();
                txbNumber.Text = caremat.number.ToString();
                txbDescription.Text = caremat.description.ToString();
                txbDistributorId.Text = caremat.distributor_id.ToString();
            }
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (cCaremat.EditCaremat(s,
                txbName.Text,
                Int32.Parse(txbPrice.Text),
                Int32.Parse(txbMass.Text),
                Int32.Parse(txbNumber.Text),
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
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.Goods.Caremat());
        }  
    }
}
