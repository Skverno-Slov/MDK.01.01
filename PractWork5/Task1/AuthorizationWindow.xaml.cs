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
using System.Security.Cryptography;

namespace Task1
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


        public string Hash(string input)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = SHA256.Create().ComputeHash(inputBytes);
            return Convert.ToHexString(hashedBytes);
        }

        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            

            string login = LoginTextBox.Text;
            string password = PasswordBox.Password;

            if (login == Properties.Settings.Default.Login && Hash(password) == Properties.Settings.Default.Password)
            {
                new SettingsWindow().ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Неверные логин или пароль");
        }
    }
}
