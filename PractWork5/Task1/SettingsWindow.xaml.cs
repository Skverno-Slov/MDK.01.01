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

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
            LoadWindow();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Login = LoginTextBox.Text;

            if (!string.IsNullOrEmpty(PasswordTextBox.Text))
                Properties.Settings.Default.Password = PasswordTextBox.Text;

            Properties.Settings.Default.Email = EmailTextBox.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Сохранено");
        }

        private void LoadWindow()
        {
            LoginTextBox.Text = Properties.Settings.Default.Login;
            PasswordTextBox.Text = Properties.Settings.Default.Password;
            EmailTextBox.Text = Properties.Settings.Default.Email;
        }
    }
}
