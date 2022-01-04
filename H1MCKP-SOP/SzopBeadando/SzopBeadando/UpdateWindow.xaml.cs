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
using SzopBeadando.BackEnd.Controllers;
using SzopBeadando.BackEnd.Model;

namespace SzopBeadando
{
    /// <summary>
    /// Interaction logic for UpdateWindow.xaml
    /// </summary>
    public partial class UpdateWindow : Window
    {
        
        private int _id;
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string data { get; set; } 
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public UpdateWindow(int id)
        {
            InitializeComponent();
            this.Id = id;

            EnergyDrink drink = new EnergyDrink();
            drink = RestController.getEnergyDrinkById(id);

            IdInputBox.Text = Id.ToString();
            BrandInputBox.Text = drink.Brand;
            CoffeinInputBox.Text = drink.Coffein_Amount;
            ModelInputBox.Text = drink.Model;
            PriceInputBox.Text = drink.Price;
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            EnergyDrink ed = new EnergyDrink();
            ed.Id = Id;
            ed.Brand = BrandInputBox.Text;
            ed.Model = ModelInputBox.Text;
            ed.Price = PriceInputBox.Text;
            ed.Coffein_Amount = CoffeinInputBox.Text;

            RestController.updateEnergyDrinkByID(ed);
            MessageBox.Show("Item updated successfully!");

            StateController.IsClosed = true;
            Update();
            this.Close();
        }

        protected void Update()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
