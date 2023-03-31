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
using System.Windows.Shapes;


namespace TouristShop.Views.Show.ElseSettings
{
    public partial class ChoiceTableForClear : Window
    {
        public ChoiceTableForClear()
        {
            InitializeComponent();
        }

        private void btnClearTent_Click(object sender, RoutedEventArgs e)
        {
            Controllers.Goods.Tent tentClear = new Controllers.Goods.Tent();

            if (MessageBox.Show("Clear all from table?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                try
                {
                    tentClear.DeleteAllTent();
                    MessageBox.Show("Table was clear");
                }
                catch
                {
                    MessageBox.Show("Somethink is wrong");
                }
            }
        }
        private void btnClearBackpack_Click(object sender, RoutedEventArgs e)
        {
            Controllers.Goods.Backpack backpackClear = new Controllers.Goods.Backpack();
            if (MessageBox.Show("Clear all from table?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                try
                {
                    backpackClear.DeleteAllBackpack();
                    MessageBox.Show("Table was clear");
                }
                catch
                {
                    MessageBox.Show("Somethink is wrong");
                }
            }
        }
        private void btnClearClothes_Click(object sender, RoutedEventArgs e)
        {
            Controllers.Goods.Clothes clothesClear = new Controllers.Goods.Clothes();

            if (MessageBox.Show("Clear all from table?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                try
                {
                    clothesClear.DeleteAllClothes();
                    MessageBox.Show("Table was clear");
                }
                catch
                {
                    MessageBox.Show("Somethink is wrong");
                }
            }
        }
        private void btnClearShoes_Click(object sender, RoutedEventArgs e)
        {
            Controllers.Goods.Shoe shoesClear = new Controllers.Goods.Shoe();

            if (MessageBox.Show("Clear all from table?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                try
                {
                    shoesClear.DeleteAllShoes();
                    MessageBox.Show("Table was clear");
                }
                catch
                {
                    MessageBox.Show("Somethink is wrong");
                }
            }
        }
        private void btnClearSleapingBags_Click(object sender, RoutedEventArgs e)
        {
            Controllers.Goods.SleapingBag sleapingBagClear = new Controllers.Goods.SleapingBag();

            if (MessageBox.Show("Clear all from table?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                try
                {
                    sleapingBagClear.DeleteAllSleapingBag();
                    MessageBox.Show("Table was clear");
                }
                catch
                {
                    MessageBox.Show("Somethink is wrong");
                }
            }
        }
        private void btnClearCaremat_Click(object sender, RoutedEventArgs e)
        {
            Controllers.Goods.Caremat carematClear = new Controllers.Goods.Caremat();

            if (MessageBox.Show("Clear all from table?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                try
                {
                    carematClear.DeleteAllCaremat();
                    MessageBox.Show("Table was clear");
                }
                catch
                {
                    MessageBox.Show("Somethink is wrong");
                }
            }
        }
        private void btnClearDishes_Click(object sender, RoutedEventArgs e)
        {
            Controllers.Goods.Dish dishClear = new Controllers.Goods.Dish();

            if (MessageBox.Show("Clear all from table?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                try
                {
                    dishClear.DeleteAllDishes();
                    MessageBox.Show("Table was clear");
                }
                catch
                {
                    MessageBox.Show("Somethink is wrong");
                }
            }
        }
        private void btnClearLiterature_Click(object sender, RoutedEventArgs e)
        {
            Controllers.Goods.Literature literatureClear = new Controllers.Goods.Literature();

            if (MessageBox.Show("Clear all from table?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                try
                {
                    literatureClear.DeleteAllLiterature();
                    MessageBox.Show("Table was clear");
                }
                catch
                {
                    MessageBox.Show("Somethink is wrong");
                }
            }
        }
        private void btnClearEquipment_Click(object sender, RoutedEventArgs e)
        {
            Controllers.Goods.Equipment equipmentClear = new Controllers.Goods.Equipment();

            if (MessageBox.Show("Clear all from table?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                try
                {
                    equipmentClear.DeleteAllEquipment();
                    MessageBox.Show("Table was clear");
                }
                catch
                {
                    MessageBox.Show("Somethink is wrong");
                }
            }
        }
        private void btnClearElectronica_Click(object sender, RoutedEventArgs e)
        {
            Controllers.Goods.Electronic electronicClear = new Controllers.Goods.Electronic();

            if (MessageBox.Show("Clear all from table?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                try
                {
                    electronicClear.DeleteAllElectronics();
                    MessageBox.Show("Table was clear");
                }
                catch
                {
                    MessageBox.Show("Somethink is wrong");
                }
            }
        }
        private void btnClearFood_Click(object sender, RoutedEventArgs e)
        {
            Controllers.Goods.Food foodClear = new Controllers.Goods.Food();

            if (MessageBox.Show("Clear all from table?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {

                if (MessageBox.Show("Clear all from table?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    try
                    {
                        foodClear.DeleteAllFood();
                        MessageBox.Show("Table was clear");
                    }
                    catch
                    {
                        MessageBox.Show("Somethink is wrong");
                    }
                }
            }
        }



        private void btnClearBuyer_Click(object sender, RoutedEventArgs e)
        {


        }
        private void btnClearDistributor_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnClearTenant_Click(object sender, RoutedEventArgs e)
        {

        }


        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
