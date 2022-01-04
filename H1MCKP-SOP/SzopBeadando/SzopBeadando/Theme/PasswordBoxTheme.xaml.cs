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

namespace SzopBeadando.Theme
{
    /// <summary>
    /// Interaction logic for PasswordBoxTheme.xaml
    /// </summary>
    public partial class PasswordBoxTheme : UserControl
    {
        public PasswordBoxTheme()
        {
            InitializeComponent();
        }

        private bool _isPasswordChanging = true;

        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Password.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(PasswordBoxTheme),
                new PropertyMetadata(string.Empty, PasswordPropertyChanged));

        private static void PasswordPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if(d is PasswordBoxTheme passwordBox)
            {
                passwordBox.UpdatePassword();
            } 
        }

        private void Passwordbox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            _isPasswordChanging = true;
            Password = passwordbox.Password;
            _isPasswordChanging = false;

        }

        private void UpdatePassword()
        {
            if(!_isPasswordChanging)
                passwordbox.Password = Password;
        }
    }
}
