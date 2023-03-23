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
    public partial class Shoe : Page
    {
        Controllers.Goods.Shoe cShoe;
        public Shoe()
        {
            InitializeComponent();

            cShoe = new Controllers.Goods.Shoe();
            ShowAllInfo();
        }

        private void ShowAllInfo()
        {
            foreach (var shoe in cShoe.GetAllShoes())
                dgridMain.Items.Add(shoe);
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Add.Goods.Shoe());
            ShowAllInfo();
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Models.Goods.Shoe path = dgridMain.SelectedItem as Models.Goods.Shoe;

            if (path == null)
                MessageBox.Show("Запис не вибрано");

            else
            {
                cShoe.DeleteOneShoes(path.id);//Видалення елементу

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
            Models.Goods.Shoe path = dgridMain.SelectedItem as Models.Goods.Shoe;

            if (path == null)
                MessageBox.Show("Запис не вибрано");
            else
            {
                int idForSearch = path.id;
                NavigationService.Navigate(new Views.Edit.Goods.Shoe(idForSearch));
            }
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.ElsePages.Goods());
        }
    }
}
