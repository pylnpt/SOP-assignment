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
using SzopBeadando.BackEnd.Controllers;
using SzopBeadando.BackEnd.Model;
using SzopBeadando.Core;
using SzopBeadando.MVVM.View;

namespace SzopBeadando
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginOrLogout_Click(object sender, RoutedEventArgs e)
        {
            if (RestController.Login(UserNameTextBox.Text, password.Password) == "Authorized")
            {
                User.UserName = UserNameTextBox.Text;
                User.Pwd = password.Password;

                
                UserNameTextBox.Opacity = 0;
                UserNameTextBox.IsEnabled = false;

                password.IsEnabled = false;
                password.Opacity = 0;
                


                usenameLabel.Opacity = 0;
                passwordLabel.Opacity = 0;
           
                StateController.LoggedIn = false;
                userBtn.Content = "Logout";

                string msg = string.Format("Logged in successfully!\nWelcome {0} !", UserNameTextBox.Text);
                MessageBox.Show(msg);
                
                password.Password = null;
                UserNameTextBox.Text = null;
            }

            else if(userBtn.Content == "Login" && (password.Password == "" || UserNameTextBox.Text == ""))
            {
                MessageBox.Show("The username and/or password field is empty.");
            }

            else if (userBtn.Content == "Logout" && UserNameTextBox.Text == "" && password.Password == "")
            { 
                User.UserName = null;
                User.Pwd = null;

                UserNameTextBox.Opacity = 100;
                UserNameTextBox.IsEnabled = true;

                password.IsEnabled = true;
                password.Opacity = 100;

                usenameLabel.Opacity = 100;
                passwordLabel.Opacity = 100;

                StateController.LoggedIn = true;
                userBtn.Content = "Login";

                MessageBox.Show("Logged out successfully!");

            }
            else 
            {
                MessageBox.Show("Incorrect credentials. Please check your username and/or password.");
            }

            
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
