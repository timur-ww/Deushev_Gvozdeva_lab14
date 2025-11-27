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

namespace SimpleLoginApp
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

        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            string username = Username.Text.ToLower();
            string password = Password.Password.ToLower();

            if (username == "student" && password == "pass123")
            {
                MessageBox.Show($"Добро пожаловать, {username}!", "Успешная регистрация", 
                    MessageBoxButton.OK, MessageBoxImage.Information);
                Username.Text = "";
                Password.Password = "";
            }
            else
            {
                MessageBox.Show("Неверные данные", "Ошибка регистрации", 
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
