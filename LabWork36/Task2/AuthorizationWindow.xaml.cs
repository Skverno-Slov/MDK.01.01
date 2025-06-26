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

namespace Task2
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTextBox.Text == "admin" && InputPasswordBox.Password == "qwerty")
            {
                AdminWindow adminWindow = new();
                Hide();
                adminWindow.ShowDialog();
                ShowDialog();
            }
            else if (LoginTextBox.Text == "manager" && InputPasswordBox.Password == "12345")
            {
                ManagerWindow managerWindow = new();
                Hide();
                managerWindow.ShowDialog();
                ShowDialog();
            }
            else
                MessageBox.Show("Не верный логин или пароль",
                    "Ошибка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
