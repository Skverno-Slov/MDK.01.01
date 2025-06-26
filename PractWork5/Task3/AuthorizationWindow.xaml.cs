using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Task3
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

        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            string[] lines = File.ReadAllLines("userData.txt");

            string currentLogin = lines[0];
            string currentPassword = lines[1];
            string userLogin = LoginTextBox.Text;
            string userPassword = PasswordBox.Password;

            if (currentLogin == userLogin && currentPassword == userPassword)
            {
                new SettingsWindow().ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Неверные логин или пароль");
        }
    }
}
