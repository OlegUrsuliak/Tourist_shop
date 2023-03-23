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
    public partial class Equipment : Page
    {
        Controllers.Goods.Equipment cEquipment;
        public int s;
        public Equipment(int idForSearcher)
        {
            s = idForSearcher; //Передача ід для визначення потрібного id
            InitializeComponent();
            cEquipment = new Controllers.Goods.Equipment();
            showOneInfo();
        }
        private void showOneInfo()
        {
            foreach (var equipment in cEquipment.GetOneEquipment(s))
            {
                txbDescription.Text = equipment.description.ToString();
                txbDistributorId.Text = equipment.distributor_id.ToString();
                txbMass.Text = equipment.mass.ToString();
                txbName.Text = equipment.name.ToString();
                txbNumber.Text = equipment.number.ToString();
                txbPrice.Text = equipment.price.ToString();
            }

        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (cEquipment.EditEquipment(s,
                txbName.Text,
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
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.Goods.Equipment());
        }
    }
}
