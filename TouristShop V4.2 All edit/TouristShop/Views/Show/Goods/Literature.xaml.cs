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
    public partial class Literature : Page
    {
        Controllers.Goods.Literature cLiterature;
        public Literature()
        {
            InitializeComponent();

            cLiterature = new Controllers.Goods.Literature();
            ShowAllInfo();
        }

        private void ShowAllInfo()
        {
            foreach (var literature in cLiterature.GetAllLiterature())
                dgridMain.Items.Add(literature);
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Add.Goods.Literature());
            ShowAllInfo();
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Models.Goods.Literature path = dgridMain.SelectedItem as Models.Goods.Literature;

            if (path == null)
                MessageBox.Show("Запис не вибрано");

            else
            {
                cLiterature.DeleteOneLiterature(path.id);//Видалення елементу

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
            Models.Goods.Literature path = dgridMain.SelectedItem as Models.Goods.Literature;

            if (path == null)
                MessageBox.Show("Запис не вибрано");
            else
            {
                int idForSearch = path.id;
                NavigationService.Navigate(new Views.Edit.Goods.Literature(idForSearch));
            }
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.ElsePages.Goods());
        }
    }
}
