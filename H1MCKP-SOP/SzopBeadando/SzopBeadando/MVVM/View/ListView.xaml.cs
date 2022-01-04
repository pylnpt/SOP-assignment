using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using SzopBeadando.BackEnd.Controllers;
using SzopBeadando.BackEnd.Model;

namespace SzopBeadando.MVVM.View
{
    /// <summary>
    /// Interaction logic for DiscoveryView.xaml
    /// </summary>
    public partial class ListView : UserControl
    {
        public static bool isClosed = false;
        public ListView()
        {
            InitializeComponent();
            ListEnergyDrinks();
        }

        private void ListEnergyDrinks()
        {
            dataGrid.Items.Clear();
            List<EnergyDrink> energyDrinks = RestController.getAllEnergyDrink();

            for (int i = 0; i < energyDrinks.Count; i++)
            {     
                dataGrid.Items.Add(new EnergyDrink()
                {
                    Id = energyDrinks[i].Id,
                    Brand = energyDrinks[i].Brand,
                    Coffein_Amount = energyDrinks[i].Coffein_Amount,
                    Model = energyDrinks[i].Model,
                    Price = energyDrinks[i].Price
                });
            }
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            if(User.UserName != null)
            {
                int enId = (dataGrid.SelectedItem as EnergyDrink).Id;
                UpdateWindow wind1 = new UpdateWindow(enId);
                wind1.UpdateEventHandler += DataGridUpdate;
                wind1.Show();
            }
            else
            {
                MessageBox.Show("You have to log in to update the items.");
            }
        }
        public void reLoadDataGrid()
        {
            if (StateController.IsClosed)
            {
                dataGrid.Items.Clear();
                ListEnergyDrinks();
                StateController.IsClosed = true;
            }
        }
        private void delete_Click(object sender, RoutedEventArgs e)
        {
            int enId = (dataGrid.SelectedItem as EnergyDrink).Id;
            RestController.deleteEnergyDrinkById(enId);

            dataGrid.Items.Clear();
            ListEnergyDrinks();
        }

        private void insert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EnergyDrink drink = new EnergyDrink();
                drink.Brand = BrandInputBox.Text;
                drink.Coffein_Amount = CoffeinInputBox.Text;
                drink.Model = ModelInputBox.Text;
                drink.Price = PriceInputBox.Text;
                
                if (drink.Brand != "" && drink.Coffein_Amount != "" && drink.Model!= "" && drink.Price != "")
                {
                    RestController.addEnergyDrink(drink);
                    dataGrid.Items.Clear();
                    ListEnergyDrinks();
                }
                else
                {
                    MessageBox.Show("Can't insert because all of fields mandatory.");
                }

                BrandInputBox.Text = "";
                CoffeinInputBox.Text = "";
                ModelInputBox.Text = "";
                PriceInputBox.Text = "";
            }
            catch (InvalidOperationException)
            {
                return;
            }      
        }

        private void DataGridUpdate(object sender, UpdateWindow.UpdateEventArgs args)
        {
            ListEnergyDrinks();
        }
    }
}
