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
    public partial class Clothes : Page
    {
        Controllers.Goods.Clothes cClothes;
        public int s;
        public Clothes()
        {

            InitializeComponent();

            cClothes = new Controllers.Goods.Clothes();
            ShowAllInfo();
        }

        private void ShowAllInfo()
        {
            foreach (var clothes in cClothes.GetAllClothes())
                dgridMain.Items.Add(clothes);
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Add.Goods.Clothes());
            ShowAllInfo();
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Models.Goods.Clothes path = dgridMain.SelectedItem as Models.Goods.Clothes;

            if (path == null)
                MessageBox.Show("Запис не вибрано");

            else
            {
                cClothes.DeleteOneClothes(path.id);//Видалення елементу

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
            Models.Goods.Clothes path = dgridMain.SelectedItem as Models.Goods.Clothes;

            if (path == null)
                MessageBox.Show("Запис не вибрано");
            else
            {
                int idForSearch = path.id;
                NavigationService.Navigate(new Views.Edit.Goods.Clothes(idForSearch));
            }
            
            ShowAllInfo();
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.ElsePages.Goods());
        }
    }
}
