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
    public partial class Setting : Page
    {
        public Setting()
        {
            InitializeComponent();
        }
        private void btnEnLanguage_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnUkLanguage_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnGrLanguage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDarkTheme_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnLightTheme_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnNeonTheme_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClearTable_Click(object sender, RoutedEventArgs e)
        {
            Views.Show.ElseSettings.ChoiceTableForClear choiceTableForClear;
            choiceTableForClear = new ElseSettings.ChoiceTableForClear();
            choiceTableForClear.Show();
        }

        private void btnClearDb_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDeleteDb_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAboutProgram_Click(object sender, RoutedEventArgs e)
        {
            Views.Show.ElseSettings.AboutProgram aboutProgramForm;
            aboutProgramForm = new ElseSettings.AboutProgram();

            aboutProgramForm.Show();
        }

        private void btnHyde_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnFeedback_Click(object sender, RoutedEventArgs e)
        {
            Views.Show.ElseSettings.Feedback feedbackForm;
            feedbackForm = new ElseSettings.Feedback();

            feedbackForm.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views.Show.ElsePages.MainMenu());
        }
    }
}
