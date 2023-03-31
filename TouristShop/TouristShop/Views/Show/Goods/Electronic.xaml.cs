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

namespace TouristShop.Views.Show.Goods
{
    public partial class Electronic : Page
    {
        Controllers.Goods.Electronic cElectronic;
        public Electronic()
        {
            InitializeComponent();

            cElectronic = new Controllers.Goods.Electronic();
            ShowAllInfo();
        }

        private void ShowAllInfo()
        {
            foreach (var electronic in cElectronic.GetAllElectronics())
                dgridMain.Items.Add(electronic);
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Add.Goods.Electronic());
            ShowAllInfo();
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Models.Goods.Electronic path = dgridMain.SelectedItem as Models.Goods.Electronic;

            if (path == null)
                MessageBox.Show("Запис не вибрано");

            else
            {
                cElectronic.DeleteOneElectronics(path.id);//Видалення елементу

                ClearDG();
                ShowAllInfo();
            }
        }
        private void ClearDG()
        {
            dgridMain.Items.Clear();
            dgridMain.Items.Refresh();
        }
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Models.Goods.Electronic path = dgridMain.SelectedItem as Models.Goods.Electronic;

            if (path == null)
                MessageBox.Show("Запис не вибрано");
            else
            {
                int idForSearch = path.id;
                NavigationService.Navigate(new Views.Edit.Goods.Electronic(idForSearch));
            }
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.ElsePages.Goods());
        }
    }
}
