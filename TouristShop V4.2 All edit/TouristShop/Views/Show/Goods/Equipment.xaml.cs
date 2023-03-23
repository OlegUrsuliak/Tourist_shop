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
    public partial class Equipment : Page
    {
        Controllers.Goods.Equipment cEquipment;
        public Equipment()
        {
            InitializeComponent();

            cEquipment = new Controllers.Goods.Equipment();
            ShowAllInfo();
        }

        private void ShowAllInfo()
        {
            foreach (var equipment in cEquipment.GetAllEquipment())
                dgridMain.Items.Add(equipment);
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Add.Goods.Equipment());
            ShowAllInfo();
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Models.Goods.Equipment path = dgridMain.SelectedItem as Models.Goods.Equipment;

            if (path == null)
                MessageBox.Show("Запис не вибрано");

            else
            {
                cEquipment.DeleteOneEquipment(path.id);//Видалення елементу

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
            Models.Goods.Equipment path = dgridMain.SelectedItem as Models.Goods.Equipment;

            if (path == null)
                MessageBox.Show("Запис не вибрано");
            else
            {
                int idForSearch = path.id;
                NavigationService.Navigate(new Views.Edit.Goods.Equipment(idForSearch));
            }
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.ElsePages.Goods());
        }
    }
}
