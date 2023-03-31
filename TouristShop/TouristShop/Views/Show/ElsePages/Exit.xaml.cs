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

namespace TouristShop.Views.Show.ElsePages
{
    public partial class Exit : Page
    {
        const string LOGIN = "1";
        const int PASSWORD = 2;

        public Exit(){
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (txbLogin.Text == LOGIN && txbPassword.Text == PASSWORD.ToString()){
                NavigationService.Navigate(new Views.Show.ElsePages.MainMenu());
            }
            else{
                MessageBox.Show("Exit error");
                //Не правильний пароль, логін або форма вже відкрита
            }
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void btnForgotPassword_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
