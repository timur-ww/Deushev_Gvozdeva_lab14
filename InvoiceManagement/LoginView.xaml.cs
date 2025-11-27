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

namespace InvoiceManagement
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var passwordEntered = PasswordBox.Password;
            string? envPw = Environment.GetEnvironmentVariable("InvoiceManagement");
            switch (envPw)
            {
                case null:
                    MessageBox.Show("Переменная среда не найдена!");
                    break;
                case var pw when pw == passwordEntered:
                    MessageBox.Show("Введен правильный пароль");
                    break;
                default:
                    MessageBox.Show("Введен не правильный пароль");
                    break;
            }
        }

        private void OnPasswordChanged(object sender, EventArgs e)
        {
            LoginButton.IsEnabled = !string.IsNullOrEmpty(PasswordBox.Password);
        }
    }
}
